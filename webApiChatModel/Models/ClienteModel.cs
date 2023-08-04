namespace webApiChatModel.Models
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public long Cpf { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Nome { get; set; }
        public bool Ativo { get; set; }

        public ClienteModel(int idCliente, long cpf, string? nomeCompleto, string? nome, bool ativo)
        {
            IdCliente = idCliente;
            Cpf = cpf;
            NomeCompleto = nomeCompleto;
            Nome = nome;
            Ativo = ativo;
        }

        public ClienteModel()
        {
            
        }
    }
}
