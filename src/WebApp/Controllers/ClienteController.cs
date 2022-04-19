using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Criar()
        {
            return View();
        }
    }
}
