using webApiChatModel.Models;
using webApiChatModel.Repositorios.MockBD;
using webApiChatModel.Repositorios;
using Xunit;

namespace WebChatTest.ApiChatTest.Repositorios
{
    public class ChatRepositorioTests
    {
        private readonly ChatRepositorio _chatRepositorio;

        public ChatRepositorioTests()
        {
            _chatRepositorio = new ChatRepositorio();
        }

        [Fact]
        public void BuscarTodasConversas_ReturnsAllConversations()
        {
            // Act
            List<ChatModel> conversas = _chatRepositorio.BuscarTodasConversas();

            // Assert
            Assert.NotNull(conversas);
            Assert.NotEmpty(conversas);
            Assert.Equal(ChatBDMock.getChatList().Count, conversas.Count);
        }

        [Fact]
        public void BuscarConversaPorId_ReturnsConversationWithMatchingId()
        {
            // Arrange
            int id = 2;

            // Act
            ChatModel conversa = _chatRepositorio.BuscarConversaPorId(id);

            // Assert
            Assert.NotNull(conversa);
            Assert.Equal(id, conversa.IdChat);
        }

        [Fact]
        public void BuscarConversaPorPergunta_ReturnsConversationWithMatchingPergunta()
        {
            // Arrange
            string pergunta = "02";

            // Act
            ChatModel conversa = _chatRepositorio.BuscarConversaPorPergunta(pergunta);

            // Assert
            Assert.NotNull(conversa);
            Assert.Equal(pergunta, conversa.Pergunta);
        }

        [Fact]
        public void BuscarConversaPorPergunta_WithInvalidPergunta_ReturnsConversationWithDefaultResponse()
        {
            // Arrange
            string pergunta = "InvalidPergunta";

            // Act
            ChatModel conversa = _chatRepositorio.BuscarConversaPorPergunta(pergunta);

            // Assert
            Assert.NotNull(conversa);
            Assert.Equal("Opção escolhida inválida, deseja falar com um atendente?", conversa.Resposta);
        }

        [Fact]
        public void BuscarConversaPorPergunta_WithArquivoPergunta_ReturnsConversationWithModifiedFields()
        {
            // Arrange
            string pergunta = "Arquivo selecionado: exemplo.txt";

            // Act
            ChatModel conversa = _chatRepositorio.BuscarConversaPorPergunta(pergunta);

            // Assert
            Assert.NotNull(conversa);
            Assert.Equal(pergunta, conversa.Pergunta);
            Assert.Equal("Recebemos o arquivo exemplo.txt com sucesso!", conversa.Resposta);
        }
    }
}
