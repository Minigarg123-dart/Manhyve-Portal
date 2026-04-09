using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class BrandingController : Controller
    {
        public IActionResult ManageBranding(string projectName)
        {
            ViewBag.ProjectName = projectName;

            // Dummy data (replace with DB later)
            var brands = new List<dynamic>
                {
                    new { StoreCode = "2947", StoreName = "SHRI KANHA AUTOMO..", SubVendor="TestVendorFF2", Status="Pending"},
                    new { StoreCode = "2946", StoreName = "Bharat Auto Service Ce..", SubVendor="TestVendorFF2", Status="Pending"},
                    new { StoreCode = "2945", StoreName = "DAKSH AUTO SERVICE..",SubVendor="Yash34", Status="Pending"},
                    new { StoreCode = "2944", StoreName = "DAKSH AUTO SERVICE..", SubVendor = "TestVendorFF2", Status = "Pending" },
                    new { StoreCode = "2943", StoreName = "AMAN AUTO PARTS, BI..", SubVendor = "TestVendorFF", Status = "Pending" },
                    new { StoreCode = "2942", StoreName = "AMAN AUTO PARTS, BI..", SubVendor = "Yash12", Status = "Pending" },
                    new { StoreCode = "2941", StoreName = "APKA BIKE POINT(BKP)", SubVendor = "TestVendorFF2", Status = "Pending" },
                    new { StoreCode = "2940", StoreName = "APKA BIKE POINT(BKP)", SubVendor = "TestVendorFF2", Status = "Pending" },
                };

            return View(brands);
        }

        public IActionResult BrandingAssignments(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult AddBranding(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }
    }
}
