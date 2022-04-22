using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IClienteRepository
    {
        Task Criar(Cliente cliente);
        Task Editar(Cliente cliente);
        Task Deletar(Cliente cliente);
        Task<Cliente> BuscarPorId(Guid id);
        Task<IList<Cliente>> BuscarTodos();
    }
}
