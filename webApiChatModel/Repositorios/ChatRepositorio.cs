using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;

namespace webApiChatModel.Repositorios
{
    public class ChatRepositorio : IChatRepositorio
    {
        private readonly List<ChatModel> _chatDB = ChatBDMock.getChatList();



        public List<ChatModel> BuscarTodasConversas()
        {
            return _chatDB.ToList();
        }

        public ChatModel BuscarConversaPorId(int id)
        {
            return _chatDB.FirstOrDefault(x => x.IdChat == id);
        }

        public ChatModel BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel chat = new ChatModel();
            chat.Pergunta = pergunta;           
            string nomeArquivo = "";

            if (pergunta.StartsWith("Arquivo selecionado:"))
            {
                int indiceDoisPontos = pergunta.IndexOf(':');

                if (indiceDoisPontos != -1 && indiceDoisPontos < pergunta.Length - 1)
                {
                    nomeArquivo = pergunta.Substring(indiceDoisPontos + 1).Trim();
                    
                }

                chat.Pergunta = pergunta;
                chat.Resposta = $"Recebemos o arquivo {nomeArquivo} com sucesso!";

            }
            else
            {
                chat = pesquisarPergunta(chat);
               
            }
           

            return chat;

        }

        private ChatModel pesquisarPergunta(ChatModel chatModel)
        {
            var result = _chatDB.Where(e => e.Pergunta.ToUpper().Equals(chatModel.Pergunta.ToUpper())).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            else
            {
                chatModel.Resposta = "Opção escolhida inválida, deseja falar com um atendente?";
                return chatModel;
            }
            
        }


    }
}
