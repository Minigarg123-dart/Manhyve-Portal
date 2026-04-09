using Microsoft.AspNetCore.Mvc;

namespace Manhyve_Portal.Controllers
{
    public class CreateFormController : Controller
    {
        public IActionResult NewForm(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }
        public IActionResult FormPage(string projectName)
        {
            ViewBag.ProjectName = projectName;
            return View();
        }

        public IActionResult MainFormSettings(string projectName)
        {
            ViewBag.ProjectName = projectName;
            var forms = new List<dynamic>
            {
                new {
                    Id=1,
                    FormName="Castrol Service",
                    ProjectName=ViewBag.ProjectName,
                    Description="Audit description",
                    CreatedDate=new DateTime(2026,1,16),
                    IsMainForm=true
                },

                new {
                    Id=2,
                    FormName="CMC (Kalinga Stone) Audit form",
                    ProjectName=ViewBag.ProjectName,
                    Description="Instructions: Mark Y for Yes",
                    CreatedDate=new DateTime(2026,1,19),
                    IsMainForm=false
                },

                new {
                    Id=3,
                    FormName="Store Audit",
                    ProjectName=ViewBag.ProjectName,
                    Description="Hello",
                    CreatedDate=new DateTime(2025,11,16),
                    IsMainForm=false
                }
            };

            return View(forms);
        }

        public IActionResult VendorFormSettings(string projectName)
        {
            ViewBag.ProjectName = projectName;
            var forms = new List<dynamic>
            {
                new {
                    Id=1,
                    FormName="Castrol Service",
                    ProjectName=ViewBag.ProjectName,
                    Description="Audit description",
                    CreatedDate=new DateTime(2026,1,16),
                    IsMainForm=true
                },

                new {
                    Id=2,
                    FormName="CMC (Kalinga Stone) Audit form",
                    ProjectName=ViewBag.ProjectName,
                    Description="Instructions: Mark Y for Yes",
                    CreatedDate=new DateTime(2026,1,19),
                    IsMainForm=false
                },

                new {
                    Id=3,
                    FormName="Store Audit",
                    ProjectName=ViewBag.ProjectName,
                    Description="Hello",
                    CreatedDate=new DateTime(2025,11,16),
                    IsMainForm=false
                }
            };

            return View(forms);
        }
    }
}
