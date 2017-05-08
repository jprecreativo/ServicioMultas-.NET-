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
            base.inicializar(500, 600);
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(rbIdentificacion.Checked)
            {
                // Hacer que se vea la pantalla de indentificación.
            }

            else if(rbConsultarPuntos.Checked)
            {

            }

            else
            {

            }
        }
    }
}
