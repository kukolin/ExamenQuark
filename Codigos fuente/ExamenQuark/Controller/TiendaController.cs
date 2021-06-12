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
    class TiendaController
    {
        Tienda tienda = new Tienda();
        public TiendaController()
        {
            Pantalon pantalon1 = new Pantalon(true);
            Camisa remera1 = new Camisa(true, true);

            List<Prenda> lista = new List<Prenda>();
            lista.Add(pantalon1);
            lista.Add(remera1);

            tienda.Nombre = "MiTienda";
            tienda.Direccion = "Direccion: Calle falsa 123";
            
            tienda.ListaPrendas = lista;
        }

        internal void escribirDireccion(Label txtDireccion)
        {
            txtDireccion.Text = tienda.Direccion;
        }

        internal void escribirNombreTienda(Label txtNombreTienda)
        {
            txtNombreTienda.Text = tienda.Nombre;

        }
    }
}
