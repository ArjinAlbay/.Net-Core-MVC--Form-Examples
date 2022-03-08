using form1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace form1.Controllers
{
    public class BiletController : Controller
    {
        public IActionResult Arama()
        {
            ViewBag.Kalkis = new List<SelectListItem>
            {
                new SelectListItem { Text = "istanbul", Value ="1"},
                new SelectListItem { Text = "ankara", Value ="2"},
                new SelectListItem { Text = "diyarbakır", Value ="3"}
            };

            ViewBag.Varis = new List<SelectListItem>
            {
                new SelectListItem{ Text ="konya", Value ="1"},
                new SelectListItem{ Text ="antep", Value ="2"},
                new SelectListItem{ Text ="urda", Value ="3"},
            };
            return View();
        }

        [HttpPost]
        public IActionResult Aramayagel(AramaViewModel arama)
        {
            ViewData["Message"] = arama.KalkisNoktasiId + "-" + arama.VarisNoktasiId + "-" + arama.YolculukTarihi + "tarihindeki uçuşlar";
            return View("Arama");  
        }
    }
}
