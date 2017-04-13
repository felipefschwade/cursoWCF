using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Passagens;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Passagens.Services.ClienteService));
            try
            { 
                host.Open();
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
    }
}
