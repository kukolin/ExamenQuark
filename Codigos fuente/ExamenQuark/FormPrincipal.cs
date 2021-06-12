using ExamenQuark.Controller;
using ExamenQuark.Model;
using ExamenQuark.Model.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuark
{
    public partial class FormPrincipal : Form
    {
        HistorialController historial;
        public FormPrincipal()
        {
            InitializeComponent();

            VendedorController vendedor = new VendedorController();
            TiendaController tienda = new TiendaController();
            historial = new HistorialController();
            vendedor.escribirNombreVendedor(this.txtNombreVendedor);
            tienda.escribirNombreTienda(this.txtNombreTienda);
            tienda.escribirDireccion(this.txtDireccion);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CotizacionController cotizacion = new CotizacionController();
            cotizacion.calcularCotizacion(cbMangaCorta, cbCuelloMao, cbChupin, rbCamisa, rbPremium, tbPrecio, tbCantidad, txtResultado, historial);
        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            cbMangaCorta.Enabled = true;
            cbCuelloMao.Enabled = true;
            cbChupin.Enabled = false;
            mostrarStock();
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            cbMangaCorta.Enabled = false;
            cbCuelloMao.Enabled = false;
            cbChupin.Enabled = true;
            mostrarStock();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            historial.mostrar();
        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            mostrarStock();

        }
        private void mostrarStock() {
            if (rbCamisa.Checked)
            {
                if (cbCuelloMao.Checked && cbMangaCorta.Checked) txtStock.Text = "Stock disponible: " + new Camisa(true, true).Stock.ToString();
                if (!cbCuelloMao.Checked && cbMangaCorta.Checked) txtStock.Text = "Stock disponible: " + new Camisa(true, false).Stock.ToString();
                if (cbCuelloMao.Checked && !cbMangaCorta.Checked) txtStock.Text = "Stock disponible: " + new Camisa(false, true).Stock.ToString();
                if (!cbCuelloMao.Checked && !cbMangaCorta.Checked) txtStock.Text = "Stock disponible: " + new Camisa(false, false).Stock.ToString();
            }
            else
            {
                if (cbChupin.Checked) txtStock.Text = "Stock disponible: " + new Pantalon(true).Stock.ToString();
                if (!cbChupin.Checked) txtStock.Text = "Stock disponible: " + new Pantalon(false).Stock.ToString();
            }
        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            mostrarStock();
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            mostrarStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
