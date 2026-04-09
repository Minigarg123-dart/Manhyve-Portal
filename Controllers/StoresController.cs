using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class StoresController : Controller
    {
        public IActionResult CreateManageStores(string projectName)
        {
            ViewBag.ProjectName = projectName;

            var audits = new List<dynamic>
                {
                    new {StoreID=1, StoreCode = "2947", StoreName = "SHRI KANHA AUTOMO..", Address="Abbasi Market Roorkee, Laksar Road", Phone="9837685610", Status="Active"},
                    new {StoreID=2,  StoreCode = "2946", StoreName = "Bharat Auto Service Ce..", Address="Abbasi Market Roorkee, Laksar Road", Phone="9837685610", Status="Active"},
                    new {StoreID = 3, StoreCode = "2945", StoreName = "DAKSH AUTO SERVICE..", Address = "Abbasi Market Roorkee, Laksar Road", Phone = "9837685610", Status = "Active" },
                    new {StoreID = 4, StoreCode = "2944", StoreName = "DAKSH AUTO SERVICE..", Address = "Abbasi Market Roorkee, Laksar Road", Phone = "9837685610", Status = "Active" },
                    new {StoreID = 5, StoreCode = "2943", StoreName = "AMAN AUTO PARTS, BI..", Address = "Abbasi Market Roorkee, Laksar Road", Phone = "9837685610", Status = "Active" },
                    new {StoreID = 6, StoreCode = "2942", StoreName = "AMAN AUTO PARTS, BI..", Address = "Abbasi Market Roorkee, Laksar Road", Phone = "9837685610", Status = "Active" },
                    new {StoreID = 8, StoreCode = "2941", StoreName = "APKA BIKE POINT(BKP)", Address = "Abbasi Market Roorkee, Laksar Road", Phone = "9837685610", Status = "Active" },
                    new {StoreID=1,  StoreCode = "2940", StoreName = "APKA BIKE POINT(BKP)", Address = "Abbasi Market Roorkee, Laksar Road" , Phone = "9837685610" , Status = "Active" },
                };

            return View(audits);
        }

        public IActionResult UploadStoreData(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult StoreAudits(string projectName)
        {
            ViewBag.ProjectName = projectName;

            var stores = new List<dynamic>
            {
                new { Name="AADIL HERO HONDA SERVICE(CHR)", Address="Thanabhawan Road, Charthawal, MUZAFFARNAGAR", Code="9834517718", Total=12, Pending=4, Approved=8 },
                new { Name="AANYA TRADERS PCO IWS RITHOURA", Address="Inder Nagar Rithoura Nawabganj, Bareilly", Code="1234567890", Total=5, Pending=2, Approved=3 },
                new { Name="AARAV HONDA SERVICE POINT", Address="M-8, Shastri Nagar, Ghaziabad", Code="9876543210", Total=10, Pending=3, Approved=7 },
                new { Name="ABDUL HADI AUTO PARTS", Address="Dantor Road, Bikaner, Rajasthan", Code="4567891234", Total=8, Pending=1, Approved=7 },
                new { Name="ABHAY CYCLE (MCO IWS) TIJARA", Address="Holi Tiba Tijara, ALWAR, RAJASTHAN", Code="5678912345", Total=6, Pending=2, Approved=4 }
            };

            return View(stores);
        }

        public IActionResult CreateNewStore(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult StoreDetails(string code)
        {
            var stores = new List<dynamic>
            {
                new { Name="AADIL HERO HONDA SERVICE(CHR)", Address="Thanabhawan Road, Charthawal, MUZAFFARNAGAR", Code="9834517718", Total=12, Pending=4, Approved=8 },
                new { Name="AANYA TRADERS PCO IWS RITHOURA", Address="Inder Nagar Rithoura Nawabganj, Bareilly", Code="1234567890", Total=5, Pending=2, Approved=3 },
                new { Name="AARAV HONDA SERVICE POINT", Address="M-8, Shastri Nagar, Ghaziabad", Code="9876543210", Total=10, Pending=3, Approved=7 },
                new { Name="ABDUL HADI AUTO PARTS", Address="Dantor Road, Bikaner, Rajasthan", Code="4567891234", Total=8, Pending=1, Approved=7 },
                new { Name="ABHAY CYCLE (MCO IWS) TIJARA", Address="Holi Tiba Tijara, ALWAR, RAJASTHAN", Code="5678912345", Total=6, Pending=2, Approved=4 }
            };

            var selectedStore = stores.FirstOrDefault(x => x.Code == code);

            return View(selectedStore);
        }
    }
}
