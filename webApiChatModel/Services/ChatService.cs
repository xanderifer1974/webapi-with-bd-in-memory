using webApiChatModel.Models;
using webApiChatModel.Repositorios;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services.Interface;
using webApiChatModel.Util;

namespace webApiChatModel.Services
{
    public class ChatService: IChatService
    {
        private readonly IChatRepositorio _chatRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ChatService(IChatRepositorio chatRepositorio, IClienteRepositorio clienteRepositorio)
        {
            _chatRepositorio = chatRepositorio;
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<ChatModel> BuscarConversaPorId(int id)
        {
           return await Task.FromResult(_chatRepositorio.BuscarConversaPorId(id));
        }

        public async Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel chatModel = new ChatModel();
            ClienteModel clienteModel = new ClienteModel();
            string nome = string.Empty;
            string resposta = string.Empty;

            if (UtilApi.ValidaCPF(pergunta))
            {
                long cpf = long.Parse(pergunta);               
                clienteModel = _clienteRepositorio.ObterClientePorCPF(cpf);

                if(clienteModel != null)
                {
                    nome = clienteModel.Nome;

                    resposta = $"<h6>Olá {nome}, escolha uma das opções abaixo.</h6>" +
                        $"<ul><li>01 – Alterar pacote de canais</li>" +
                        $"<li>02 – Alterar dados cadastrais</li>" +
                        $"<li>03 – Solicitar um novo ponto</li>" +
                        $"<li>04 – Alterar endereço da assinatura</li>" +
                        $"<li>05 – Solicitar segunda via da fatura</li>" +
                        $"<li>06 – Renegociar dívida</li>" +
                        $"<li>07 – Cancelar assinatura</li>" +
                        $"<li>08 - Falar com um atendente</li></ul>";

                    chatModel.Resposta = resposta;
                }
                else
                {
                    resposta = "Não encontramos seu CPF em nossas bases de cadastro. Favor informar um CPF válido.";
                    chatModel.Resposta = resposta;
                }

            }
            else
            {
                chatModel = _chatRepositorio.BuscarConversaPorPergunta(pergunta);
            }
           
            return await Task.FromResult(chatModel);
        }

        public async Task<List<ChatModel>> BuscarTodasConversas()
        {
            return await Task.FromResult(_chatRepositorio.BuscarTodasConversas());
        }
    }
}
