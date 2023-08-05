using ChatWeb.Trainning.Domain.Interfaces.Entidades;
using ChatWeb.Trainning.Domain.Models;
using ChatWeb.Trainning.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWeb.Trainning.Infra.Repository.Entidades
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataBaseContext _context;

        public ClienteModel Alterar(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Incluir(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteModel> Listar()
        {
            throw new NotImplementedException();
        }

        public ClienteModel Obter(int id)
        {
            throw new NotImplementedException();
        }
    }
}
