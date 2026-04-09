using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class GigWorkerController : Controller
    {
        public IActionResult LoginPage()
        {
            var workers = new List<dynamic>
            {
                new { Id = 37, FullName = "Prashant ajabsing tawar", UserName="Prashant", Status="Active"},
                new { Id = 36, FullName = "Manjeet Singh", UserName="manjeet@123", Status="Active"},
                new { Id = 35, FullName = "Vijender", UserName="9306557796", Status="Active"},
                new { Id = 34, FullName = "Hansbir", UserName="Hansbir", Status="Active"},
                new { Id = 33, FullName = "MANESH KUMAR MAHTO", UserName="Manesh@96", Status="Active"},
                new { Id = 32, FullName = "MANESH KUMAR MAHTO", UserName="MANESH KUMAR MAHTO", Status="Active"},
                new { Id = 31, FullName = "VIKRAM TIRKEY", UserName="VIKRAM", Status="Active"},
                new { Id = 30, FullName = "Sourabh kumar", UserName="Sourabh2516", Status="Active"},
                new { Id = 29, FullName = "Anil Kumar", UserName="Anil Kumar", Status="Active"}
            };

            return View(workers);
        }

        public IActionResult GigWorkerStatus()
        {
            var workers = new List<dynamic>
            {
                new { FullName="Prashant ajabsing tawar", Status="Pending Review"},
                new { FullName="Manjeet Singh", Status="Pending Review"},
                new { FullName="Vijender", Status="Pending Review"},
                new { FullName="Hansbir", Status="Pending Review"},
                new { FullName="MANESH KUMAR MAHTO", Status="Pending Review"},
                new { FullName="VIKRAM TIRKEY", Status="Pending Review"},
                new { FullName="Sourabh kumar", Status="Pending Review"}
            };

            return View(workers);
        }

        public IActionResult GigWorkerBulkUpload(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        [HttpPost]
        public IActionResult UploadGigWorkerCSV(IFormFile file)
        {
            var workers = new List<dynamic>();

            if (file != null && file.Length > 0)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    reader.ReadLine(); // skip header

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        workers.Add(new
                        {
                            FullName = values[0],
                            CurrentState = values[1],
                            Status = "Pending Review"
                        });
                    }
                }
            }

            return View("GigWorkerStatus", workers);
        }
    }
}
