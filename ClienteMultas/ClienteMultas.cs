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

            // Console.WriteLine("Antes de indentificarme");

            Servicio servicioMultas = new Servicio();
            // Console.WriteLine("Antes de indentificarme");
            Console.WriteLine(servicioMultas.Identificacion("541293AGP"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaInicial(servicioMultas));
        }
    }
}
