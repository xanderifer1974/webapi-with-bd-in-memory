using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.Interfaces
{
    public interface IChatRepositorio
    {
        List<ChatModel> BuscarTodasConversas();
        ChatModel BuscarConversaPorId(int id);
        ChatModel BuscarConversaPorPergunta(string pergunta);

    }
}
