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
    public partial class PantallaBajaVehiculo : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaBajaVehiculo(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            int dni;
            String dniTexto = tbDNI.Text;

            if (Int32.TryParse(dniTexto, out dni))
            {
                int result;
                String mat = tbMat.Text;

                if ((result = servicioMultas.BajaVehiculo(dni, mat)) == 1)
                {
                    textoBaja.ForeColor = Color.Black;
                    textoBaja.Text = "El vehículo se ha dado del baja correctamente.";
                }

                else
                {
                    textoBaja.ForeColor = Color.Red;
                    textoBaja.Text = "Los datos especificados no son correctos o el vehículo no está dado de alta.";
                }
            }

            else
            {
                textoBaja.ForeColor = Color.Red;
                textoBaja.Text = "Los datos especificados no son correctos o el vehículo no está dado de alta.";
            }
        }
    }
}
