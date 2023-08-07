using ChatWeb.Trainning.Domain.Interfaces.Entidades;
using ChatWeb.Trainning.Domain.Models;
using ChatWeb.Trainning.Infra.Repository.Context;

namespace ChatWeb.Trainning.Infra.Repository.Entidades
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataBaseContext _context;

        public ClienteRepository(DataBaseContext ctx)
        {
          _context = ctx;
        }

        public ClienteModel Alterar(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            ClienteModel cliente = this.Obter(id);

            if( cliente == null )
                return false;

            _context.Remove(cliente);
            _context.SaveChanges();

            return true;
        }

        public ClienteModel Incluir(ClienteModel cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public IEnumerable<ClienteModel> Listar()
        {
            return _context.Clientes.ToList();
        }

        public ClienteModel Obter(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(a => a.IdCliente == id);
            if (cliente == null)
            {
                throw new InvalidOperationException($"Cliente com ID {id} não foi encontrado.");
            }
            return cliente;
        }
    }
}
