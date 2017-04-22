using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMultas
{
    public class Conductor
    {
        private int dni;
        private int puntos;

        public Conductor()
        {

        }

        public Conductor(int dni, int puntos)
        {
            this.dni = dni;
            this.puntos = puntos;
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

        public int Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }
    }
}
