using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    /// <summary>
    /// Pantalla que se abrirá al iniciar la aplicación. Contiene el menú de consultas.
    /// </summary>
    public partial class PantallaInicial : Pantalla
    {
        public PantallaInicial()
        {
            this.InitializeComponent();
            base.inicializar(500, 600);
            this.TopMost = true;
        }
    }
}
