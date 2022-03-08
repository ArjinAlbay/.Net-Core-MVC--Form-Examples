using form1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace form1.Controllers
{
    public class MyAdress : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Cities = new List<SelectListItem>
            {
                new SelectListItem { Text = "diyarbakır", Value ="1"},
                new SelectListItem { Text = "İstanbul", Value = "2" },
                new SelectListItem { Text = "Ankara", Value = "3" }
            };
            
            ViewBag.Towns = new List<SelectListItem>
            {
                new SelectListItem { Text = "bağlar", Value ="1"},
                new SelectListItem { Text = "bağcılar", Value = "2" },
                new SelectListItem { Text = "çankaya", Value = "3" }
            };
            return View();
        }


       [HttpPost]
       public IActionResult Indexegel(MyAdres myadres)
        {

     
            return View("Index");
        }
    }
}
