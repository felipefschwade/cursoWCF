using Passagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Interfaces
{
    interface IClienteService
    {
        Cliente Buscar(string nome);
        void Add(Cliente cliente);
    }
}
