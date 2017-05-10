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

        public PantallaConsultarMultas(Servicio servicioMultas)
        {
            InitializeComponent();
            this.InitializeComponent();
            base.inicializar();
            this.TopMost = true;
            this.servicioMultas = servicioMultas;
        }
    }
}
