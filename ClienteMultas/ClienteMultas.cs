using ClienteMultas;
using ServicioMultas;
using ServicioMultas.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMultas
{
    static class ClienteMultas
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ChannelServices.RegisterChannel(new TcpChannel(), true);

            try
            {
                RemotingConfiguration.Configure("ClienteMultas.exe.config", false);
            }
            
            catch
            {
                Console.WriteLine("Problemas al leer configuración.");
            }

            Servicio servicioMultas = new Servicio();

            int DNI1 = 45134789, DNI2 = 45111786;
            String mat1 = "7861-HJI", mat2 = "5661-LLK", mat3 = "0988-HKP";

            // El servicioMultas, al dar de alta a los vehículos, crea el mismo a los conductores:

            servicioMultas.AltaVehiculo(DNI1, mat1);
            servicioMultas.AltaVehiculo(DNI1, mat2);
            servicioMultas.AltaVehiculo(DNI2, mat3);

            // Pongo algunas multas:

            servicioMultas.PonerMulta(mat2, "01/04/2017-13:00", 6);
            servicioMultas.PonerMulta(mat3, "01/04/2017-13:00", 2);

            // Para probar que todo ha ido bien, compruebo puntos y multas:
            
            LinkedList<Multa> m1 = servicioMultas.ComprobarMultas(DNI1, mat1);
            LinkedList<Multa> m2 = servicioMultas.ComprobarMultas(DNI1, mat2);
            LinkedList<Multa> m3 = servicioMultas.ComprobarMultas(DNI2, mat3);
            
            Console.WriteLine("\nSe han puesto las siguientes multas:\n");
            
            foreach(Multa m in m1)
                Console.WriteLine(m.Mat + " " + m.Fecha + " " + m.Puntos);
            
            foreach(Multa m in m2)
                Console.WriteLine(m.Mat + " " + m.Fecha + " " + m.Puntos);
            
            foreach(Multa m in m3)
                Console.WriteLine(m.Mat + " " + m.Fecha + " " + m.Puntos);
            
            Console.Write("\nEl conductor de DNI " + DNI1 + " tiene ");
            Console.WriteLine(servicioMultas.ComprobarPuntos(DNI1, mat1));
            
            Console.Write("El conductor de DNI " + DNI1 + " tiene ");
            Console.WriteLine(servicioMultas.ComprobarPuntos(DNI1, mat2));
            
            Console.Write("El conductor de DNI " + DNI2 + " tiene ");
            Console.WriteLine(servicioMultas.ComprobarPuntos(DNI2, mat3));
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaInicial(servicioMultas));
        }
    }
}
