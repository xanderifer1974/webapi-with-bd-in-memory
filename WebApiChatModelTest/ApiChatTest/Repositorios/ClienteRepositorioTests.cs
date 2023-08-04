using webApiChatModel.Models;
using webApiChatModel.Repositorios.MockBD;
using webApiChatModel.Repositorios;
using Xunit;

namespace WebChatTest.ApiChatTest.Repositorios
{
    public class ClienteRepositorioTests
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClienteRepositorioTests()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        [Fact]
        public void ListarTodosClientes_ReturnsAllClients()
        {
            // Act
            List<ClienteModel> clientes = _clienteRepositorio.ListarTodosClientes();

            // Assert
            Assert.NotNull(clientes);
            Assert.NotEmpty(clientes);
            Assert.Equal(ChatBDMock.getClienteList().Count, clientes.Count);
        }

        [Fact]
        public void ObterClientePorCPF_ReturnsClientWithMatchingCPF()
        {
            // Arrange
            long cpf = 21201141028;

            // Act
            ClienteModel cliente = _clienteRepositorio.ObterClientePorCPF(cpf);

            // Assert
            Assert.NotNull(cliente);
            Assert.Equal(cpf, cliente.Cpf);
        }

        [Fact]
        public void ObterClientePorCPF_WithInvalidCPF_ReturnsNull()
        {
            // Arrange
            long cpf = 123456789;

            // Act
            ClienteModel cliente = _clienteRepositorio.ObterClientePorCPF(cpf);

            // Assert
            Assert.Null(cliente);
        }
    }
}
