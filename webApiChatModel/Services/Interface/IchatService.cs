using webApiChatModel.Models;

namespace webApiChatModel.Services.Interface
{
    public interface IChatService
    {
        Task<List<ChatModel>> BuscarTodasConversas();
        Task<ChatModel> BuscarConversaPorId(int id);
        Task<ChatModel> BuscarConversaPorPergunta(string pergunta);
    }
}
