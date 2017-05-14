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
    public partial class PantallaPonerMulta : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaPonerMulta(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btMultar_Click(object sender, EventArgs e)
        {
            int puntos = (int) spPuntos.Value;
            String mat = tbMat.Text, fecha = DateTime.Now.ToString("dd/MM/yyyy-HH:mm");
            int result = servicioMultas.PonerMulta(mat,fecha, puntos);

            if(result == 1)
            {
                textoMulta.ForeColor = Color.Black;
                textoMulta.Text = "La multa se ha puesto correctamente.";
            }

            else
            {
                textoMulta.ForeColor = Color.Red;
                textoMulta.Text = "Los datos especificados no son correctos.";
            }
        }
    }
}
