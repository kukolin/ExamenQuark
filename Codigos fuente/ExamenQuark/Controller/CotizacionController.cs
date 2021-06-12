using ExamenQuark.Model;
using ExamenQuark.Model.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuark.Controller
{
    class CotizacionController
    {
        Camisa camisa;
        Pantalon pantalon;
        internal void calcularCotizacion(CheckBox cbMangaCorta, CheckBox cbCuelloMao, CheckBox cbChupin, RadioButton rbCamisa, RadioButton rbPremium, TextBox tbPrecio, TextBox tbCantidad, Label txtResultado, HistorialController historial)
        {


            double precio = this.validarPrecio(tbPrecio.Text);
            if (precio == 0) return;
            int cantidad = this.validarCantidad(tbCantidad.Text);
            if (cantidad == 0) return;


            
            string resultado;

            if (rbCamisa.Checked) {
                if (cbMangaCorta.Checked)
                {
                    if (cbCuelloMao.Checked)
                    {
                        camisa = new Camisa(true, true); //Con manga corta y MAO
                    }
                    else { camisa = new Camisa(true, false); } //Con manga corta y sin MAO
                }
                else {
                    if (cbCuelloMao.Checked) {
                        camisa = new Camisa(false, true);  //Sin manga corta y MAO
                    }
                    else { camisa = new Camisa(false, false); } //Sin manga corta y sin MAO
                }
                if (rbPremium.Checked) //Con premium
                {
                    camisa.Premium = true;
                }
                else //Sin premium
                {
                    camisa.Premium = false;
                }

                camisa.Precio = precio;
                if (camisa.Stock < cantidad) {
                    MessageBox.Show("No hay suficiente stock disponible");
                    return;
                }
                resultado = camisa.getPrecio(cantidad).ToString();
                this.guardar(camisa, cantidad, resultado, historial); // Guardo en el historial

            }
            else {

                if (cbChupin.Checked)
                {
                    pantalon = new Pantalon(true);
                }
                else
                {
                    pantalon = new Pantalon(false);
                }
                if (rbPremium.Checked) //Con premium
                {
                    pantalon.Premium = true;
                }
                else //Sin premium
                {
                    pantalon.Premium = false;
                }

                pantalon.Precio = precio;
                if (pantalon.Stock < cantidad)
                {
                    MessageBox.Show("No hay suficiente stock disponible");
                    return;
                }
                resultado = pantalon.getPrecio(cantidad).ToString();
                this.guardar(pantalon, cantidad, resultado, historial); // Guardo en el historial

            }

            txtResultado.Text = "Resultado: " + resultado; //Imprimo resultado

        }

        private int validarCantidad(string text)
        {
            try {
                int cantidad = Convert.ToInt32(text);
                return cantidad;
            }
            catch (Exception) {
                MessageBox.Show("Campo 'cantidad' contiene un formato inválido.");
                return 0;
            }
        }

        private double validarPrecio(string text)
        {
            try
            {
                double precio = Convert.ToDouble(text);
                return precio;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo 'precio' contiene un formato inválido.");
                return 0;
            }
        }
        private void guardar(Prenda prenda, int unidades, string resultado, HistorialController historial) {
            historial.save(prenda, unidades, resultado);
        }
    }
}
