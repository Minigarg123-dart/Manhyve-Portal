using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
