using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.MockBD
{
    public static class ChatBDMock
    {
        /*
         * Ver um modo de simular um banco de dados utilizando os dados mockado
         * Colocar todo o código nas camadas mais internas também */
        public static  List<ChatModel> getChatList()
        {
            List<ChatModel> listaChat = new List<ChatModel>();

            ChatModel conversa1 = new ChatModel(01, "01", $"<h6>Alterar Pacotes de Canais:</h6>" +
                        $"<ul><li>101 – Pacote Full</li>" +
                        $"<li>102 – Pacote Filmes</li>" +
                        $"<li>103 -  Pacote Básico</li>" +                      
                        $"</ul>");
            ChatModel conversa2 = new ChatModel(2, "101", "Você escolheu o <b>Pacote Full</b>. Iremos providenciar a alteração.");
            ChatModel conversa3 = new ChatModel(3, "102", "Você escolheu o <b>Pacote Filmes</b>. Iremos providenciar a alteração.");
            ChatModel conversa4 = new ChatModel(4, "103", "Você escolheu o <b>Pacote Básico</b>. Iremos providenciar a alteração.");
            ChatModel conversa5 = new ChatModel(5, "02", $"<h6>Alterar dados cadastrais:</h6>" +
                        $"<ul><li>201 – Nome</li>" +
                        $"<li>202 – RG</li>" +
                        $"<li>203 - CPF</li>" +
                        $"<li>204 - Telefone</li>" +
                        $"<li>205 - Endereço</li>" +
                        $"</ul>");
            ChatModel conversa6 = new ChatModel(6, "201", "Você escolheu o <b> Alteração do Nome</b>.Iremos prosseguir com a alteração.");
            ChatModel conversa7 = new ChatModel(7, "202", "Você escolheu o <b> Alteração do RG</b>.Iremos prosseguir com a alteração.");
            ChatModel conversa8 = new ChatModel(8, "203", "Você escolheu o <b> Alteração do CPF</b>.Iremos prosseguir com a alteração.");
            ChatModel conversa9 = new ChatModel(9, "204", "Você escolheu o <b> Alteração do Telefone</b>.Iremos prosseguir com a alteração.");
            ChatModel conversa10 = new ChatModel(10, "205", "Você escolheu o <b> Alteração do Endereço</b>.Iremos prosseguir com a alteração.");
            ChatModel conversa11 = new ChatModel(11, "Sim", "Iremos te encaminhar para um atendente, aguarde...");
            ChatModel conversa12 = new ChatModel(12, "Não", "Obrigado por entrar em contato. Qualquer coisa, estamos a sua disposição.");
            ChatModel conversa13 = new ChatModel(13, "Gostaria de atualizar os dados de cadastro.", "Favor nos enviar os dados em arquivo. ");

            listaChat.Add(conversa1);
            listaChat.Add(conversa2);
            listaChat.Add(conversa3);
            listaChat.Add(conversa4);
            listaChat.Add(conversa5);
            listaChat.Add(conversa6);
            listaChat.Add(conversa7);
            listaChat.Add(conversa8);
            listaChat.Add(conversa9);
            listaChat.Add(conversa10);
            listaChat.Add(conversa11);
            listaChat.Add(conversa12);
            listaChat.Add(conversa13);

            return listaChat;
        }

        public static List<ClienteModel> getClienteList()
        {
            List<ClienteModel> listCliente = new List<ClienteModel>();

            ClienteModel cliente1 = new ClienteModel(1, 21201141028, "Antonio Figueiredo de Oliveira","Antonio", true);
            ClienteModel cliente2 = new ClienteModel(2, 28698103006, "Graziela Lopes Nunes","Graziela", true);
            ClienteModel cliente3 = new ClienteModel(3, 31554257093, "Paulo Roberto Silva Santos","Paulo Roberto", true);
            ClienteModel cliente4 = new ClienteModel(4, 72407118030, "João Paulo Martins", "João Paulo", true);
            ClienteModel cliente5 = new ClienteModel(5, 28432913057, "Amanda Bitencourt de Azevedo", "Amanda",true);
            ClienteModel cliente6 = new ClienteModel(6, 44831758078, "Simone Cury Machado","Simone", true);
            ClienteModel cliente7 = new ClienteModel(7, 99588085012, "Gabriel Marcos Limeira","Gabriel Marcos", true);
            ClienteModel cliente8 = new ClienteModel(8, 07982351018, "Rafael Pedreira de Souza","Rafael", true);
            ClienteModel cliente9 = new ClienteModel(9, 03647631086, "Lucia das Neves Ferreira","Lucia", true);
            ClienteModel cliente10 = new ClienteModel(10, 33391558016, "Ezequiel Medeiros Mendonza","Ezequiel", true);

            listCliente.Add(cliente1);
            listCliente.Add(cliente2);
            listCliente.Add(cliente3);
            listCliente.Add(cliente4);
            listCliente.Add(cliente5);
            listCliente.Add(cliente6);
            listCliente.Add(cliente7);
            listCliente.Add(cliente8);
            listCliente.Add(cliente9);
            listCliente.Add(cliente10);

            return listCliente;

        }
    }
}
