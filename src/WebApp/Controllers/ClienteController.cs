using Dominio.IRepositories;
using Historia.Clientes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly CriarCliente _criarCliente;
        private readonly ConsultarCliente _consultarCliente;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _criarCliente = new CriarCliente(clienteRepository);
            _consultarCliente = new ConsultarCliente(clienteRepository);
        }


        public async Task<IActionResult> Index()
        {
            var listaCliente = await _consultarCliente.BuscarTodosClientes();
            var listaClienteViewModel = ClienteFactory.MapearListaClienteViewModel(listaCliente);
            return View(listaClienteViewModel);
        }


        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = ClienteFactory.MapearParaEntidadeCliente(clienteViewModel);
                await _criarCliente.Executar(cliente);
                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }
    }
}
