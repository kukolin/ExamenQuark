using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model.Dominio
{
    class Pantalon : Prenda
    {
        bool chupin;
        public bool Chupin { get => chupin; set => chupin = value; }

        public Pantalon(bool chupin): base() {
            this.Chupin = chupin;
            if (chupin) this.Stock = 1500; else this.Stock = 500;
        }

        public override double getPrecio(int cantidad) {
            base.getPrecio(cantidad);

                if (chupin) {
                    Precio = Precio * 0.88;
                }

            return Precio;
        }

    }
}
