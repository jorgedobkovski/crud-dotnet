using Dominio.Entidade;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class CriarCliente
    {
        private readonly IClienteRepository _clienteRepository;
        public CriarCliente(IClienteRepository clienteRepository)
        {
           _clienteRepository = clienteRepository;
        }

        public async Task Executar(Cliente cliente)
        {
            await _clienteRepository.Criar(cliente);
        }
    }
}
