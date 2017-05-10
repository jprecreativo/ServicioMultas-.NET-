using ClienteMultas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioMultas.Forms
{
    /// <summary>
    /// Pantalla que se abrirá al iniciar la aplicación. Contiene el menú de consultas.
    /// </summary>
    public partial class PantallaInicial : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaInicial(Servicio servicioMultas)
        {
            this.InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            if(rbIdentificacion.Checked)
                new PantallaIdentificacion(servicioMultas).Visible = true;

            else if(rbConsultarPuntos.Checked)
                new PantallaConsultarPuntos(servicioMultas).Visible = true;

            else
                new PantallaConsultarMultas(servicioMultas).Visible = true;
        }
    }
}
