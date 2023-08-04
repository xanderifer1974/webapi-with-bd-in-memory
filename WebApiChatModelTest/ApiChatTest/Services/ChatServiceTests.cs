using Moq;
using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services;
using Xunit;

namespace WebChatTest.ApiChatTest.Services
{
    public class ChatServiceTests
    {
        private readonly Mock<IChatRepositorio> _chatRepositorioMock;
        private readonly Mock<IClienteRepositorio> _clienteRepositorioMock;

        public ChatServiceTests()
        {
            _chatRepositorioMock = new Mock<IChatRepositorio>();
            _clienteRepositorioMock = new Mock<IClienteRepositorio>();
        }

        [Fact]
        public async Task BuscarConversaPorId_DeveRetornarChatModel()
        {
            // Arrange
            int id = 1;
            var chatModelEsperado = new ChatModel();
            _chatRepositorioMock.Setup(repo => repo.BuscarConversaPorId(id)).Returns(chatModelEsperado);
            var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

            // Act
            var resultado = await chatService.BuscarConversaPorId(id);

            // Assert
            Assert.Equal(chatModelEsperado, resultado);
        }

        [Fact]
        public async Task BuscarConversaPorPergunta_DeveRetornarChatModel()
        {
            // Arrange
            string pergunta = "Qual é a pergunta?";
            var chatModelEsperado = new ChatModel();
            _chatRepositorioMock.Setup(repo => repo.BuscarConversaPorPergunta(pergunta)).Returns(chatModelEsperado);
            var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

            // Act
            var resultado = await chatService.BuscarConversaPorPergunta(pergunta);

            // Assert
            Assert.Equal(chatModelEsperado, resultado);
        }


        [Fact]
        public async Task BuscarConversaPorPergunta_DeveRetornarRespostaQuandoCPFValido()
        {
            // Arrange
            string pergunta = "21201141028"; // CPF válido
            var clienteModel = new ClienteModel { Nome = "João" };
            _clienteRepositorioMock.Setup(repo => repo.ObterClientePorCPF(It.IsAny<long>())).Returns(clienteModel);
            var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

            // Act
            var resultado = await chatService.BuscarConversaPorPergunta(pergunta);
            var resposta = $"<h6>Olá {clienteModel.Nome}, escolha uma das opções abaixo.</h6>" +
                        $"<ul><li>01 – Alterar pacote de canais</li>" +
                        $"<li>02 – Alterar dados cadastrais</li>" +
                        $"<li>03 – Solicitar um novo ponto</li>" +
                        $"<li>04 – Alterar endereço da assinatura</li>" +
                        $"<li>05 – Solicitar segunda via da fatura</li>" +
                        $"<li>06 – Renegociar dívida</li>" +
                        $"<li>07 – Cancelar assinatura</li>" +
                        $"<li>08 - Falar com um atendente</li></ul>";

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal(resposta, resultado.Resposta);
        }
    }
}
