using Dominio.Entidade;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class ConsultarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public ConsultarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> BuscarTodosClientes()
        {
            return await _clienteRepository.BuscarTodos();
        }
    }
}
