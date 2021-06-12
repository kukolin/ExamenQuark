using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model.Dominio
{
    class Tienda
    {
        string nombre, direccion;
        List<Prenda> listaPrendas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> ListaPrendas { get => listaPrendas; set => listaPrendas = value; }
    }
}
