using Passagens.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Passagens.Entidades;
using Passagens.DAO;

namespace Passagens.Services
{
    class ClienteService : IClienteService
    {
        public void Add(Cliente cliente)
        {
            var dao = new ClienteDAO();
            dao.Add(cliente);
        }
        public Cliente Buscar(string nome)
        {
            var dao = new ClienteDAO();
            return dao.Buscar(nome);
        }
    }
}
