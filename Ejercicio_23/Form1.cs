using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_20_Robado;

namespace Ejercicio_23
{
    public partial class Conversor : Form
    {

        public Conversor()
        {
            InitializeComponent();
            CotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            CotizacionEuro.Text = Euros.GetCotizacion().ToString();
            CotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void BotonBloqueado_Click(object sender, EventArgs e)
        {
            if (CotizacionDolar.Enabled)
            {
                BotonBloqueado.Image = imageList1.Images[0];
                CotizacionDolar.Enabled = false;
                CotizacionEuro.Enabled = false;
                CotizacionPeso.Enabled = false;
            }
            else
            {
                BotonBloqueado.Image = imageList1.Images[1];
                CotizacionDolar.Enabled = true;
                CotizacionEuro.Enabled = true;
                CotizacionPeso.Enabled = true;
            }

        }



        private void CotizacionEuro_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(CotizacionEuro.Text, out double auxCotizacion))
            {
                Euros.SetCotizacion(auxCotizacion);
            }
            else
            {
                CotizacionEuro.Focus();
            }
        }

        private void CotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(CotizacionDolar.Text, out double auxCotizacion))
            {
                Dolar.SetCotizacion(auxCotizacion);
            }
            else
            {
                CotizacionDolar.Focus();
            }
        }

        private void CotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(CotizacionPeso.Text, out double auxCotizacion))
            {
                Pesos.SetCotizacion(auxCotizacion);
            }
            else
            {
                CotizacionPeso.Focus();
            }
        }

        private void BotonDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(EntradaDolar.Text, out double dolar))
            {
                Dolar moneda = new Dolar(dolar);
                Dolar_Dolar.Text= moneda.GetCantidad().ToString();
                Dolar_Euro.Text = ((Euros)moneda).GetCantidad().ToString();
                Dolar_Peso.Text = ((Pesos)moneda).GetCantidad().ToString();
            }
            else
            {
                EntradaDolar.Focus();
            }
        }
        private void BotonEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(EntradaEuro.Text, out double euros))
            {
                Euros moneda = new Euros(euros);

                Euro_Euro.Text = moneda.GetCantidad().ToString();
                Euro_Dolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                Euro_Peso.Text = ((Pesos)moneda).GetCantidad().ToString();
            } 
            else
            {
                EntradaEuro.Focus();
            }

        }

        private void BotonPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(EntradaPeso.Text, out double pesos))
            {
                Pesos moneda = new Pesos(pesos);
                
                Peso_Euro.Text = ((Euros)moneda).GetCantidad().ToString();
                Peso_Dolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                Peso_Peso.Text = moneda.GetCantidad().ToString();
            }
            else
            {
                EntradaPeso.Focus();
            }
        }
    }
}
