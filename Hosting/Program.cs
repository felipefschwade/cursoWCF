using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Passagens;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Passagens.Services.ClienteService));
            var uri = new Uri("http://localhost:8080/clientes");
            try
            {
                host.AddServiceEndpoint(typeof(Passagens.Interfaces.IClienteService), new BasicHttpBinding(), uri);
                host.Open();
                ExibeInformacoesServico(host);
                Console.ReadKey();
                host.Close();
            }
            catch(Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
