using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        List<ClienteModel> ListarTodosClientes();
        ClienteModel ObterClientePorCPF(long cpf);
       
    }
}
