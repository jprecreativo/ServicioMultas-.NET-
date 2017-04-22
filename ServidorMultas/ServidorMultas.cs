using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMultas
{
    class ServidorMultas
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpChannel(12345), false);   // ¿Por qué false?

            Console.WriteLine("Activando el servicio de multas en modo publicación...");   // ¿Diferencia con Singleton?

            RemotingServices.Marshal(new ServicioMultas(), "ServicioMultas");

            Console.WriteLine("Esperando llamadas remotas...");
            Console.WriteLine("\nPulsa ENTER para salir.");
            Console.ReadLine();
        }
    }
}
