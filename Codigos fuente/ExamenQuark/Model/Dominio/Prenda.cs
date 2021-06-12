using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark.Model.Dominio
{
    abstract class Prenda
    {
        #region DOMINIO
        private bool premium;
        private double precio;
        private int stock;

        public bool Premium { get => premium; set => premium = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        #endregion

        #region IMPLEMENTACION
        public virtual double getPrecio(int cantidad)
        {
            if (premium)
            {
                precio = precio * 1.3;
            }
            precio = precio * cantidad;
            return precio;
        }
        #endregion
    }

}
