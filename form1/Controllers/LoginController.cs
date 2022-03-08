using form1.Models;
using Microsoft.AspNetCore.Mvc;

namespace form1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Loginegel(User user)
        {
            if (user != null &&
                 user.Email == "akapella.1899@gmail.com" &&
                user.Nickname == "kral2121" &&
                user.Password == "123"
                )
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["Message"] = "hatalı giriş";

            return View("Login");


        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registeregel(Register register)
        {
            if (register != null &&
                register.Name == "kral2121"&&
                register.Mail == "akapella.1899@gmail.com"  &&
                register.Password == "145" 
                )
            {
                //TempData["Message1"] = "kayıt başarılı.";
                return RedirectToAction("Index", "Home");
            }

            ViewData["Message1"] = "eksik veya hatalı giriş";
            return View("Register");
        }

    }
}
