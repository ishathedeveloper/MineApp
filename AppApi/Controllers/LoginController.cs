using Microsoft.AspNetCore.Mvc;

namespace AppApi.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
