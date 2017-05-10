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
    public partial class PantallaGestion : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaGestion(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.Text = "Pantalla Gestión";
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            if (rbPonerMulta.Checked)
                new PantallaPonerMulta(servicioMultas).Visible = true;

            else if (rbQuitarMulta.Checked)
                new PantallaQuitarMulta(servicioMultas).Visible = true;

            else if(rbAlta.Checked)
                new PantallaAltaVehiculo(servicioMultas).Visible = true;

            else
                new PantallaBajaVehiculo(servicioMultas).Visible = true;
        }
    }
}
