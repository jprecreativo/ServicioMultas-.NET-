﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMultas
{
    public class Multa
    {
        private string mat;
        private string fecha;
        private int puntos;

        public Multa()
        {

        }

        public Multa(string mat, string fecha, int puntos)
        {

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

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
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
