using login_reg_withoutDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace login_reg_withoutDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            HttpContext.Session.SetString("email", user.Email);
            HttpContext.Session.SetString("password", user.Password);
            return RedirectToAction("Login");

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            string email=HttpContext.Session.GetString("email");
            string password=HttpContext.Session.GetString("password");
            if(email==user.Email && password ==user.Password)
            {
                ViewBag.Msg = "Login sucessfully";
            }
            else
            {
                ViewBag.Msg = "Login Failed";
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
