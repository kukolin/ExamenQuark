using ExamenQuark.Model.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model
{
    class Camisa : Prenda
    {
        bool mangaCorta;
        bool cuelloMao;
        public bool MangaCorta { set => mangaCorta = value; }
        public bool CuelloMao {set => cuelloMao = value; }

        public Camisa(bool mangaCorta, bool cuelloMao): base() {
            this.mangaCorta = mangaCorta;
            this.CuelloMao = cuelloMao;
            if (mangaCorta)
            {
                if (cuelloMao) this.Stock = 200; else this.Stock = 300;
            }
            else 
            {
                if (cuelloMao) this.Stock = 150; else this.Stock = 350;
            }

        }



        public override double getPrecio(int cantidad)
        {
            base.getPrecio(cantidad);
            
            if (mangaCorta)
            {
                Precio = Precio * 0.9;
            }
            if (cuelloMao)
            {
                Precio = Precio * 1.03;
            }

            return Precio;
        }
    }
}
