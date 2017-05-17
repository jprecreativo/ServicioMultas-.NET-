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
    public partial class PantallaConsultarMulta : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaConsultarMulta(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btConsultarMulta_Click(object sender, EventArgs e)
        {
            int dni;
            String dniTexto = tbDNI.Text;

            tbMulta.Text = "";

            if(Int32.TryParse(dniTexto, out dni))
            {
                LinkedList<Multa> multas = servicioMultas.ComprobarMultas(dni, tbMat.Text);

                if(multas.Count == 0)   // No hay multas o datos incorrectos.
                {
                    textoMulta.ForeColor = Color.Red;
                    textoMulta.Text = "No hay multas o los datos son incorrectos.";
                }

                else
                {
                    textoMulta.ForeColor = Color.Black;
                    textoMulta.Text = "Se han encontrado las siguientes multas:";

                    foreach(Multa m in multas)
                        tbMulta.Text += "Fecha: " + m.Fecha + "   Puntos: " + m.Puntos + "\n\n";
                }
            }
        }
    }
}
