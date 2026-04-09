using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }
    }
}
