using webApiChatModel.Models;
using webApiChatModel.Repositorios.MockBD;
using Xunit;

namespace WebChatTest.ApiChatTest.Repositorios.MockBD
{
    public class ChatBDMockTests
    {
        [Fact]
        public void GetChatList_ReturnsNonEmptyList()
        {
            // Act
            List<ChatModel> chatList = ChatBDMock.getChatList();

            // Assert
            Assert.NotNull(chatList);
            Assert.NotEmpty(chatList);
        }

        [Fact]
        public void GetClienteList_ReturnsNonEmptyList()
        {
            // Act
            List<ClienteModel> clienteList = ChatBDMock.getClienteList();

            // Assert
            Assert.NotNull(clienteList);
            Assert.NotEmpty(clienteList);
        }
    }
}
