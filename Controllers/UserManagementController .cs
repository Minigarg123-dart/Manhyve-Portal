using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }
    }
}
