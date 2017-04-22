using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMultas
{
    public class ServicioMultas : MarshalByRefObject
    {
        private readonly ArrayList vehiculos;
        private readonly ArrayList conductores;
        private readonly ArrayList multas;

        // Funciones privadas del servicio:
        
        /// <summary>
        ///  Se usará cuando haga falta saber si un vehículo está dado de alta.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo que se quiere comprobar si está o no dado de alta. </param>
        /// <returns> La posición del vehículo en el array 'vehiculos' o -1 si no existe el vehículo. </returns>
        private int existeVehiculo(String mat)
        {
            int pos = 0;
            bool existe = false;

            while (!existe && pos < vehiculos.Capacity)
            {
                Vehiculo vehiculo = (Vehiculo) vehiculos[pos];

                if(mat.Equals(vehiculo.Mat, StringComparison.InvariantCultureIgnoreCase))
                    existe = true;

                else
                    pos++;
            }

            if (existe)
                return pos;

            return -1;
        }

        /// <summary>
        /// Averigua quien es dueño del vehículo de matrícula 'mat'.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo en cuestión. </param>
        /// <returns> El DNI del propietario de vehículo o -1 si no se encuentra al propietario. </returns>
        private int propietarioVehiculo(string mat)
        {
            int pos = 0;
            bool propietario = false;
        
            while (!propietario && pos < vehiculos.Capacity)
            {
                Vehiculo vehiculo = (Vehiculo) vehiculos[pos];

                if(mat.Equals(vehiculo.Mat, StringComparison.InvariantCultureIgnoreCase))
                    propietario = true;

                else
                    pos++;
            }

            if (propietario)
            {
                Vehiculo vehiculo = (Vehiculo) vehiculos[pos];

                return vehiculo.Dni;
            }
        
            return -1;
        }

        /// <summary>
        /// Busca a un conductor.
        /// </summary>
        /// <param name="dni"> DNI del conductor a buscar. </param>
        /// <returns> Posición del conductor en el array 'conductores' o -1 si no existe. </returns>
        private int buscarUsuario(int dni)
        {
            int pos = 0;
            bool usuario = false;

            while (!usuario && pos < conductores.Capacity)
            {
                Conductor conductor = (Conductor) conductores[pos];

                if(dni == conductor.Dni)
                    usuario = true;

                else
                    pos++;
            }

            if (usuario)
                return pos;

            return -1;
        }

        /// <summary>
        /// Comprueba si una multa es de un conductor en concreto.
        /// </summary>
        /// <param name="dni"> DNI del conductor. </param>
        /// <param name="mat"> Matrícula del vehículo multado. </param>
        /// <returns> TRUE si el conductor es dueño del vehículo, FALSE en caso contrario. </returns>
        private bool esMiMulta(int dni, string mat)
        {
            int pos = 0;
            bool encontrado = false;

            while (!encontrado && pos < vehiculos.Capacity)
            {
                Vehiculo vehiculo = (Vehiculo) vehiculos[pos];

                if (vehiculo.Dni == dni && mat.Equals(vehiculo.Mat, StringComparison.InvariantCultureIgnoreCase))
                    encontrado = true;

                else
                    pos++;
            }

            return encontrado;
        }

        /// <summary>
        /// Sanciona al conductor que sea propietario del vehículo con matrícula 'mat' quitándole 'puntos' puntos.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo que ha sido multado. </param>
        /// <param name="puntos"> Puntos de la multa. </param>
        private void quitarPuntos(string mat, int puntos)
        {
            int dni = this.propietarioVehiculo(mat);

            if (dni != -1)
            {
                int pos = this.buscarUsuario(dni);

                if (pos != -1)
                {
                    Conductor sancionado = (Conductor) conductores[pos];
                    int puntosActuales = sancionado.Puntos;

                    if (puntosActuales - puntos > 0)
                        sancionado.Puntos = puntosActuales - puntos;

                    else
                        sancionado.Puntos = 0;
                }
            }
        }

        /// <summary>
        /// Busca una multa en el array 'multas'.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo multado. </param>
        /// <param name="fecha"> Fecha de la multa. </param>
        /// <returns> La posición de la multa en el array 'multas' o -1 si no está la multa. </returns>
        private int buscarMulta(string mat, string fecha)
        {
            int pos = 0;
            bool encontrado = false;

            while (!encontrado && pos < multas.Capacity)
            {
                Multa multa = (Multa) multas[pos];
                
                if (mat.Equals(multa.Mat, StringComparison.InvariantCultureIgnoreCase) && fecha.Equals(multa.Fecha, StringComparison.InvariantCultureIgnoreCase))
                    encontrado = true;

                else
                    pos++;
            }    

            if (encontrado)
                return pos;

            return -1;
        }

        /// <summary>
        /// Devuelve puntos a un conductor.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo a cuyo dueño se le devolverá los puntos. </param>
        /// <param name="puntos"> Puntos a devolver. </param>
        private void devolverPuntos(string mat, int puntos)
        {
            int dni = this.propietarioVehiculo(mat);

            if (dni != -1)
            {
                int pos = buscarUsuario(dni);

                if (pos != -1)
                {
                    Conductor absuelto = (Conductor) conductores[pos];

                    absuelto.Puntos = absuelto.Puntos + puntos;
                }
            }
        }

        /// <summary>
        /// Dará de alta a un conductor en el caso de que no lo esté.
        /// </summary>
        /// <param name="dni"> DNI del conductor que daremos de alta. </param>
        private void altaUsuario(int dni)
        {
            if (this.buscarUsuario(dni) == -1)
                conductores.Add(new Conductor(dni, 12));
        }

        /// <summary>
        /// Se utilizará para saber si un vehículo tiene alguna multa.
        /// </summary>
        /// <param name="mat"> Matrícula del vehículo. </param>
        /// <returns> TRUE si el vehículo tiene alguna multa, FALSE en caso contrario. </returns>
        private bool tieneMulta(string mat)
        {
            int i = 0;
            bool encontrada = false;

	        while(!encontrada && i < multas.Capacity)
            {
                Multa multa = (Multa) multas[i];

                if(mat.Equals(multa.Mat, StringComparison.InvariantCultureIgnoreCase))
                    encontrada = true;

                else
                    i++;
            }
            
	        return encontrada;
        }

        // ------------------------------------------------------------------------------------------------------------------
        
        // Funciones públicas del servicio:

        public ServicioMultas()
        {
            vehiculos = new ArrayList();
            conductores = new ArrayList();
            multas = new ArrayList();
        }

        public int ComprobarPuntos(int dni, string mat)
        {
            int result, dniPropietario, pos = -1;

            if (this.existeVehiculo(mat) != -1)
            {
                dniPropietario = propietarioVehiculo(mat);

                if (dni == dniPropietario)   // Si el vehículo es mío.
                    pos = buscarUsuario(dniPropietario);
            }

            if (pos == -1)
                result = -1;

            else
            {
                Conductor conductor = (Conductor) conductores[pos];

                result = conductor.Puntos;
            }

            return result;
        }

        public LinkedList<Multa> ComprobarMultas(int dni, string mat)
        {
            LinkedList<Multa> misMultas = new LinkedList<Multa>();

	        if(this.existeVehiculo(mat) != -1)
	        {
                    foreach(Multa actual in multas) 
                        if(mat.Equals(actual.Mat, StringComparison.InvariantCultureIgnoreCase) && this.esMiMulta(dni, actual.Mat))
                            misMultas.AddLast(actual);
	        }

	        return misMultas;
        }

        public int Identificacion(string pass)
        {
            if (pass.Equals("541293AGP", StringComparison.InvariantCultureIgnoreCase))
                return 1;

            return 0;
        }

        public int PonerMulta(string mat, string fecha, int puntos)
        {
            int result = 0;

            if (this.existeVehiculo(mat) != -1)
            {
                multas.Add(new Multa(mat, fecha, puntos));
                this.quitarPuntos(mat, puntos);
                result = 1;
            }

            return result;
        }

        public int QuitarMulta(string mat, string fecha)
        {
            int result = 0, pos = this.buscarMulta(mat, fecha);

            if (pos != -1)
            {
                Multa multa = (Multa) multas[pos];

                multas.Remove(pos);
                this.devolverPuntos(mat, multa.Puntos);
                result = 1;
            }

            return result;
        }

        public int AltaVehiculo(int dni, string mat)
        {
            int result = 0;

            if (this.existeVehiculo(mat) == -1)
            {
                vehiculos.Add(new Vehiculo(dni, mat));
                this.altaUsuario(dni);
                result = 1;
            }

            return result;
        }

        public int BajaVehiculo(int dni, string mat)
        {
            int result = 0, pos = this.existeVehiculo(mat);

            if (pos != -1 && !this.tieneMulta(mat))
            {
                vehiculos.Remove(pos);
                result = 1;
            }

            return result;
        }
    }
}
