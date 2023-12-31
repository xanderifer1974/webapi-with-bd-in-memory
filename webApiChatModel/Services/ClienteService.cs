﻿using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
           _clienteRepositorio = clienteRepositorio;
        }

        public List<ClienteModel> ListarTodosClientes()
        {
           return _clienteRepositorio.ListarTodosClientes();
        }

        public ClienteModel ObterClientePorCPF(long cpf)
        {  
            return _clienteRepositorio.ObterClientePorCPF(cpf);
        }
    }
}
