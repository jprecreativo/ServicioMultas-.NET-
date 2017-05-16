using ServicioMultas;
using ServicioMultas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMultas.Forms
{
    public partial class PantallaConsultarPuntos : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaConsultarPuntos(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void mostrarPuntos()
        {
            int dni;
            // String dniTexto = tbDNI.Text;

            if (Int32.TryParse(tbDNI.Text, out dni))
            {
                int puntos;
                String mat = tbMat.Text;

                if((puntos = servicioMultas.ComprobarPuntos(dni, mat)) != -1)
                {
                    textoPuntos.ForeColor = Color.Black;
                    textoPuntos.Text = "El conductor de DNI " + dni + " tiene " + puntos + " puntos.";
                }

                else
                {
                    textoPuntos.ForeColor = Color.Red;
                    textoPuntos.Text = "Los datos especificados no son correctos.";
                }
            }

            else
            {
                textoPuntos.ForeColor = Color.Red;
                textoPuntos.Text = "Los datos especificados no son correctos.";
            }
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            this.mostrarPuntos();
        }

        private void tbMat_TextChanged(object sender, EventArgs e)
        {
            this.mostrarPuntos();
        }
    }
}
