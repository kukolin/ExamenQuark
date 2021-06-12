using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model.Dominio
{
    class Vendedor
    {
        private string nombre, apellido, codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
