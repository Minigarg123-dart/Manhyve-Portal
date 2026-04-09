using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class AuditController : Controller
    {
        public IActionResult CreateAudit(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult ManageAudits(string projectName)
        {
            ViewBag.ProjectName = projectName;

            // Dummy data (replace with DB later)
            var audits = new List<dynamic>
                {
                    new {AuditID=1, StoreCode = "2947", StoreName = "SHRI KANHA AUTOMO..", Status="Approved"},
                    new {AuditID=2, StoreCode = "2946", StoreName = "Bharat Auto Service Ce..", Status="Approved",Address="Abbasi Market Roorkee, Laksar Road", CapturedBy="FruitloopsTest1"},
                    new { AuditID = 3, StoreCode = "2946", StoreName = "Bharat Auto Service Ce..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 4, StoreCode = "2945", StoreName = "DAKSH AUTO SERVICE..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 5, StoreCode = "2944", StoreName = "DAKSH AUTO SERVICE..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 6, StoreCode = "2943", StoreName = "AMAN AUTO PARTS, BI..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 7, StoreCode = "2942", StoreName = "AMAN AUTO PARTS, BI..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 8, StoreCode = "2941", StoreName = "APKA BIKE POINT(BKP)", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                    new { AuditID = 9, StoreCode = "2940", StoreName = "APKA BIKE POINT(BKP)", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1" },
                };

            return View(audits);
        }

        public IActionResult AuditAssignments(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult AuditDetails(string projectName, int AuditID)
        {
            ViewBag.ProjectName = projectName;

            var audits = new List<dynamic>
            {
                new {AuditID=1, StoreCode="2947", StoreName="SHRI KANHA AUTOMO..", Status="Approved",Address="Abbasi Market Roorkee, Laksar Road", CapturedBy="FruitloopsTest1", TakenOn="2/26/2026, 5:23:22 PM", FileName="form-photo-1772106800255.jpg",Location="28.443557, 77.055103"},
                new {AuditID=2, StoreCode="2946", StoreName="Bharat Auto Service Ce..", Status="Approved",Address="Abbasi Market Roorkee, Laksar Road", CapturedBy="FruitloopsTest1", TakenOn="2/26/2026, 5:23:22 PM", FileName="form-photo-1772106800255.jpg",Location="28.443557, 77.055103"},
                new { AuditID = 3, StoreCode = "2946", StoreName = "Bharat Auto Service Ce..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 4, StoreCode = "2945", StoreName = "DAKSH AUTO SERVICE..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 5, StoreCode = "2944", StoreName = "DAKSH AUTO SERVICE..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 6, StoreCode = "2943", StoreName = "AMAN AUTO PARTS, BI..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 7, StoreCode = "2942", StoreName = "AMAN AUTO PARTS, BI..", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 8, StoreCode = "2941", StoreName = "APKA BIKE POINT(BKP)", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
                new { AuditID = 9, StoreCode = "2940", StoreName = "APKA BIKE POINT(BKP)", Status = "Approved", Address = "Abbasi Market Roorkee, Laksar Road", CapturedBy = "FruitloopsTest1", TakenOn = "2/26/2026, 5:23:22 PM", FileName = "form-photo-1772106800255.jpg", Location = "28.443557, 77.055103" },
            };

            var audit = audits.FirstOrDefault(a => a.AuditID == AuditID);

            return View(audit);
        }
    }
}
