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
    public partial class PantallaAltaVehiculo : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaAltaVehiculo(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            int dni;
            String dniTexto = tbDNI.Text;

            if (Int32.TryParse(dniTexto, out dni))
            {
                int result;
                String mat = tbMat.Text;

                if ((result = servicioMultas.AltaVehiculo(dni, mat)) == 1)
                {
                    textoPuntos.ForeColor = Color.Black;
                    textoPuntos.Text = "El vehículo se ha dado del alta correctamente.";
                }

                else
                {
                    textoPuntos.ForeColor = Color.Red;
                    textoPuntos.Text = "Los datos especificados no son correctos o el vehículo ya está dado de alta.";
                }
            }

            else
            {
                textoPuntos.ForeColor = Color.Red;
                textoPuntos.Text = "Los datos especificados no son correctos o el vehículo ya está dado de alta.";
            }

            textoPuntos.Visible = true;
        }
    }
}
