using webApiChatModel.Models;
using Xunit;

namespace WebChatTest.ApiChatTest.Models
{
    public class ChatModelTest
    {
        [Fact]
        public void DefaultConstructor_InitializedCorrectly()
        {
            // Arrange
            var chatModel = new ChatModel();

            // Assert
            Assert.Null(chatModel.IdChat);
            Assert.Null(chatModel.Pergunta);
            Assert.Null(chatModel.Resposta);
            Assert.False(chatModel.ArquivoEmAnexo);
        }

        [Fact]
        public void ParameterizedConstructor1_InitializedCorrectly()
        {
            // Arrange
            int idChat = 1;
            string pergunta = "Pergunta";
            string resposta = "Resposta";

            // Act
            var chatModel = new ChatModel(idChat, pergunta, resposta);

            // Assert
            Assert.Equal(idChat, chatModel.IdChat);
            Assert.Equal(pergunta, chatModel.Pergunta);
            Assert.Equal(resposta, chatModel.Resposta);
            Assert.False(chatModel.ArquivoEmAnexo);
        }

        [Fact]
        public void ParameterizedConstructor2_InitializedCorrectly()
        {
            // Arrange
            int idChat = 1;
            string pergunta = "Pergunta";
            string resposta = "Resposta";
            bool anexo = true;

            // Act
            var chatModel = new ChatModel(idChat, pergunta, resposta, anexo);

            // Assert
            Assert.Equal(idChat, chatModel.IdChat);
            Assert.Equal(pergunta, chatModel.Pergunta);
            Assert.Equal(resposta, chatModel.Resposta);
            Assert.Equal(anexo, chatModel.ArquivoEmAnexo);
        }
    }
}
