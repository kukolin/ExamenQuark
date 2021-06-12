using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model.Dominio
{
    class Cotizacion
    {
        private int numeroIdentif;
        private DateTime fechaHora;
        private Vendedor vendedor;
        private Prenda prenda;
        private int unidades;
        private string resultado;

        public int NumeroIdentif { get => numeroIdentif; set => numeroIdentif = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public Prenda Prenda { get => prenda; set => prenda = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        internal Vendedor Vendedor { get => vendedor; set => vendedor = value; }


    }
}
