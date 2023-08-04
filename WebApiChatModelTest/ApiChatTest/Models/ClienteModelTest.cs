using webApiChatModel.Models;
using Xunit;

namespace WebChatTest.ApiChatTest.Models
{
    public class ClienteModelTest
    {

        [Fact]
        public void Constructor_WithParameters_SetsProperties()
        {
            // Arrange
            int idCliente = 1;
            long cpf = 1234567890;
            string nomeCompleto = "Fulano de Tal";
            string nome = "Fulano";
            bool ativo = true;

            // Act
            ClienteModel cliente = new ClienteModel(idCliente, cpf, nomeCompleto, nome, ativo);

            // Assert
            Assert.Equal(idCliente, cliente.IdCliente);
            Assert.Equal(cpf, cliente.Cpf);
            Assert.Equal(nomeCompleto, cliente.NomeCompleto);
            Assert.Equal(nome, cliente.Nome);
            Assert.Equal(ativo, cliente.Ativo);
        }


        [Fact]
        public void DefaultConstructor_DoesNotThrowException()
        {
            // Arrange & Act
            ClienteModel cliente = new ClienteModel();

            // Assert
            Assert.NotNull(cliente);
        }
    }
}
