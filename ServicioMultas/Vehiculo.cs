using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMultas
{
    public class Vehiculo
    {
        private int dni;
        private string mat;

        public Vehiculo()
        {

        }

        public Vehiculo(int dni, string mat)
        {
            this.dni = dni;
            this.mat = mat;
        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Mat
        {
            get
            {
                return mat;
            }

            set
            {
                mat = value;
            }
        }
    }
}
