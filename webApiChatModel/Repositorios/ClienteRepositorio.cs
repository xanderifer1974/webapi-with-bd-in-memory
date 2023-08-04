using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;

namespace webApiChatModel.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        
        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> list = ChatBDMock.getClienteList();

            return  list;

        }

        public ClienteModel ObterClientePorCPF(long cpf)
        {         
          
          ClienteModel cliente = ChatBDMock.getClienteList().FirstOrDefault(c => c.Cpf == cpf);
         
          return cliente;
        }       
    }
}
