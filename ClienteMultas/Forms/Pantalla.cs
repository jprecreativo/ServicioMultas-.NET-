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
    /// La clase abstracta Pantalla servirá de modelo para todas las pantalls de la aplicación.
    /// </summary>
    public partial class Pantalla : Form
    {
        public void inicializar(int ancho, int alto)
        {
            this.Size = new Size(ancho, alto);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Icon = new Icon("../../Images/iconoDGT.ico");
        }
    }
}
