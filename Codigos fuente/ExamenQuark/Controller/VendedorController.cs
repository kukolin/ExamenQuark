using ExamenQuark.Model.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuark.Controller
{
    class VendedorController
    {
        Vendedor vendedor = new Vendedor();
        public VendedorController() {
            vendedor.Nombre = "Lucas";
            vendedor.Apellido = "Anezin";
            vendedor.Codigo = "0012";
        }

        internal void escribirNombreVendedor(Label txtNombreVendedor)
        {
            txtNombreVendedor.Text = "Vendedor: " + vendedor.Nombre + " " + vendedor.Apellido + " | " + vendedor.Codigo;
        }
    }
}
