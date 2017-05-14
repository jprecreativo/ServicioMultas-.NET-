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
                    textoAlta.ForeColor = Color.Black;
                    textoAlta.Text = "El vehículo se ha dado del alta correctamente.";
                }

                else
                {
                    textoAlta.ForeColor = Color.Red;
                    textoAlta.Text = "Los datos especificados no son correctos o el vehículo ya está dado de alta.";
                }
            }

            else
            {
                textoAlta.ForeColor = Color.Red;
                textoAlta.Text = "Los datos especificados no son correctos o el vehículo ya está dado de alta.";
            }
        }
    }
}
