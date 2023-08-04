using webApiChatModel.Models;

namespace webApiChatModel.Services.Interface
{
    public interface IClienteService
    {
        List<ClienteModel> ListarTodosClientes();
        ClienteModel ObterClientePorCPF(long cpf);
       
    }
}
