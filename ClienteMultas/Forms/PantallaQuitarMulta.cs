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
    public partial class PantallaQuitarMulta : Pantalla
    {
        private Servicio servicioMultas;

        public PantallaQuitarMulta(Servicio servicioMultas)
        {
            InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            String mat = tbMat.Text, fecha = tBFecha.Text;
            int result = servicioMultas.QuitarMulta(mat, fecha);

            if(result == 1)
            {
                textoMulta.ForeColor = Color.Black;
                textoMulta.Text = "Se ha quitado la multa correctamente.";
            }

            else
            {
                textoMulta.ForeColor = Color.Red;
                textoMulta.Text = "Los datos especificados no son correctos.";
            }
        }
    }
}
