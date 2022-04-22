using Dominio.Entidade;
using System.Collections;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class ClienteFactory
    {
        public static Cliente MapearParaEntidadeCliente(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = new(
                clienteViewModel.Nome, 
                clienteViewModel.CPF,
                clienteViewModel.RG, 
                clienteViewModel.DataNascimento
                );

            return cliente;
        }

        public static ClienteViewModel MapearParaClienteViewModel(Cliente cliente)
        {
            var clienteViewModel = new ClienteViewModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                RG = cliente.RG,
                DataNascimento = cliente.DataNascimento
            };            

            return clienteViewModel;
        }

        public static IEnumerable<ClienteViewModel> MapearListaClienteViewModel(IEnumerable<Cliente> clientes)
        {
            var lista = new List<ClienteViewModel>();
            foreach (var cliente in clientes)
            {
                lista.Add(MapearParaClienteViewModel(cliente));
            }
            return lista;
        }
    }
}
