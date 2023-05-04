using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MineApp.Models;
using MineModels.Models;
using System.Diagnostics;

namespace MineApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }


      public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                HttpContext.SignOutAsync();
                return RedirectToAction("Login");

            }
            return View();

        }

        [HttpPost]
        public async Task <IActionResult> Login(LoginModel obj)
        {

            var data=await login



            return View();
        }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}