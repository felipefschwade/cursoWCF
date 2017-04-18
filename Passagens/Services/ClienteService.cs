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
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            var cliente = new Cliente() { Nome = nome, Cpf = cpf };
            var dao = new ClienteDAO();
            dao.Add(cliente);

            return true;
        }
        public Cliente Buscar(string nome)
        {
            var dao = new ClienteDAO();
            return dao.Buscar(nome);
        }

        public IList<Cliente> listaTodos()
        {
            var dao = new ClienteDAO();
            return dao.ListaTodos();
        }
    }
}
