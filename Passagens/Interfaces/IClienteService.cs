using Passagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Interfaces
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente Buscar(string nome);
        [OperationContract]
        void Add(Cliente cliente);
    }
}
