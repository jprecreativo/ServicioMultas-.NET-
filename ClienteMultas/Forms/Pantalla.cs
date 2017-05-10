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
    /// La clase abstracta Pantalla servirá de modelo para todas las pantalls de la aplicación.
    /// </summary>
    public partial class Pantalla : Form
    {
        public void inicializar()
        {
            /*
             * Poner en este método el tamaño de la pantalla es innecesario, ya que
             * en la pantalla "Propiedades" pondré manualmente el tamaño de cada una
             * de las pantallas.
             */

            // this.Size = new Size(ancho, alto);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Icon = new Icon("../../Images/iconoDGT.ico");
        }
    }
}
