using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class DemoImagesController : Controller
    {
        public IActionResult UploadDemoImages(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }
        public IActionResult ViewDemoImages(string projectName)
        {
            ViewBag.ProjectName = projectName;

            var stores = new List<dynamic>
            {
                new { Name="DIAMOND AUTO SERVICE CENTER", Code="2476670489"},
                new { Name="PUNJAB MAHINERY STORE, GNR", Code="9219897222"},
                new { Name="SAI MOTOR", Code="1210016072"},
                new { Name="Jogniya Motors-PCO, Bhilwara", Code="9601022916"},
                new { Name="Munna Maruti Workshop", Code="9862756136"},
                new { Name="ABHAY CYCLE (MCO IWS) TIJARA", Code="9539079687"},
                new { Name="FRIENDS MOTORS (HMH)", Code="9651377496"},
                new { Name="MISHRA AUTO ELECTRICION", Code="9199986796"},
                new { Name="Xpert car care, Rajnagar", Code="9572261358"},
                new { Name="teststore1001", Code="364"},
                new { Name="Balaji Motors", Code="9471877037"},
                new { Name="JUBER CAR SERVICE CENTER", Code="9894203717"},
            };

            return View(stores);
        }
    }
}
