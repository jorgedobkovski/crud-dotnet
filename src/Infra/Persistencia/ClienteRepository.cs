using Dominio.Entidade;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Cliente> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Cliente>> BuscarTodos()
        {
            return await _dataContext.Clientes.AsNoTracking().ToListAsync(); 
        }

        public async Task Criar(Cliente cliente)
        {
            _dataContext.Clientes.Add(cliente);
            await _dataContext.SaveChangesAsync();
        }

        public Task Deletar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task Editar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
