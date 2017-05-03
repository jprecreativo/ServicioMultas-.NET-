using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMultas
{
    class ServidorMultas
    {
        static void Main(string[] args)
        {
            /* ChannelServices.RegisterChannel(new TcpChannel(12345), true);   

            Console.WriteLine("Activando el servicio de multas en modo publicación...");

            RemotingServices.Marshal(new ServicioMultas(), "ServicioMultas"); */

            try
            {
                RemotingConfiguration.Configure("ServidorMultas.exe.config", false);
            }
            
            catch
            {
                Console.WriteLine("Problemas al leer configuración.");
            }

            Console.WriteLine("Esperando llamadas remotas...");
            Console.WriteLine("\nPulsa ENTER para salir.");
            Console.ReadLine();
        }
    }
}
