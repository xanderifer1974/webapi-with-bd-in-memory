using ChatWeb.Trainning.Domain.Models;

namespace ChatWeb.Trainning.Domain.Interfaces.Entidades
{
    public interface IClienteRepository
    {
        public ClienteModel Incluir(ClienteModel cliente);
        public ClienteModel Alterar(ClienteModel cliente);
        public bool Excluir(int id);
        public IEnumerable<ClienteModel> Listar();
        public ClienteModel Obter(int id);
    }
}
