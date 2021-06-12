using ExamenQuark.Model.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuark.Controller
{
    class HistorialController
    {
        Cotizacion cotizacion = new Cotizacion();
        List<Cotizacion> listaCotizaciones = new List<Cotizacion>();

        public void save(Prenda prenda, int unidades, string resultado) {

            cotizacion.Prenda = prenda;
            cotizacion.Unidades = unidades;
            cotizacion.Resultado = resultado;
            cotizacion.NumeroIdentif = listaCotizaciones.Count + 1;
            cotizacion.FechaHora = DateTime.Now;

            listaCotizaciones.Add(cotizacion);

        }

        public void mostrar() {

            FormHistorial form = new FormHistorial();

            for (int i=0; i<listaCotizaciones.Count;i++) {
                string item = "Numero: " + listaCotizaciones[i].NumeroIdentif + ", Fecha: " + listaCotizaciones[i].FechaHora.ToString() + ", Unidades: " + listaCotizaciones[i].Unidades + ", Resultado: " + listaCotizaciones[i].Resultado;

                form.listBox1.Items.Add(item);
            }


            form.ShowDialog();

        }
    }
}
