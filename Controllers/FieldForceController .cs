using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class FieldForceController : Controller
    {
        public IActionResult AddAgent(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult ManageFieldForce(string projectName)
        {
            ViewBag.ProjectName = projectName;

            var fieldForce = new List<dynamic>
                {
                    new { UserName = "randhirkumar", Email = "randhir7186@gmail.com", Phone="N/A", Address="N/A", Pincode="N/A"},
                    new { UserName = "sandeepbhatnagar", Email = "sandeepbhatnagar@gmail.com", Phone="N/A", Address="N/A", Pincode="N/A"},
                    new { UserName = "baldevsingh", Email = "baldevsingh0513@gmail.com", Phone = "N/A", Address = "N/A", Pincode = "N/A" },
                    new { UserName = "sureshbalai", Email = "sureshkumerkhandela4@gmail.com", Phone = "N/A", Address = "N/A" , Pincode = "N/A" },
                    new { UserName = "mukeshserawat", Email = "mukeshserawat321@gmail.com", Phone = "N/A", Address = "N/A" , Pincode = "N/A" },
                    new { UserName = "ashishsharma", Email = "ashishsharma3151@gmail.com", Phone = "N/A", Address = "N/A" , Pincode = "N/A" },
                    new { UserName = "lalitbairwa", Email = "lalitkbairwat23@gmail.com", Phone = "N/A", Address = "N/A" , Pincode = "N/A" },
                };

            return View(fieldForce);
        }

        public IActionResult ManageVendors(string projectName)
        {
            ViewBag.ProjectName = projectName;

            var audits = new List<dynamic>
                {
                    new { UserName = "YashT", Email = "yasht2@gmail.com", Phone="123456", Status="Active", CreatedAt="2026-02-17" },
                    new { UserName = "TestVendor", Email = "testvendor@gmail.com", Phone="7148523691", Status="Active", CreatedAt="2026-02-21" },
            
                };

            return View(audits);
        }
    }
}
