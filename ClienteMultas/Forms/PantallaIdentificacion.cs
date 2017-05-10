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
    public partial class PantallaIdentificacion : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaIdentificacion(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.Text = "Identifícate";
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            int result = servicioMultas.Identificacion(dni.Text);

            if(result == 0)
            {
                MessageBox.Show("El DNI introducido no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                dni.Text = "";
            }

            else
            {
                this.Dispose();
                new PantallaGestion(servicioMultas).Visible = true;
            }
        }
    }
}
