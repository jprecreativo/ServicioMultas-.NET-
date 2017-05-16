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
    public partial class PantallaConsultarMultas : Pantalla
    {
        private Servicio servicioMultas;
        private DataTable tablaMultas;

        public PantallaConsultarMultas(Servicio servicioMultas)
        {
            InitializeComponent();
            this.InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;

            tablaMultas = new DataTable("Multas");
            vistaMultas.DataSource = this.tablaMultas;
        }

        private void btVerMultas_Click(object sender, EventArgs e)
        {
            int dni;
            // String dniTexto = tbDNI.Text;

            if(Int32.TryParse(tbDNI.Text, out dni))
            {
                LinkedList<Multa> multas = servicioMultas.ComprobarMultas(dni, tbMat.Text);
                DataRow nuevaFila = tablaMultas.NewRow();
                int i = 1;

                foreach(Multa m in multas)
                {
                    nuevaFila["#"] = i++;
                    nuevaFila["Matrícula"] = m.Mat;
                    nuevaFila["Fecha"] = m.Fecha;
                    nuevaFila["Puntos"] = m.Puntos;

                    tablaMultas.Rows.Add(nuevaFila);
                }
            }
        }
    }
}
