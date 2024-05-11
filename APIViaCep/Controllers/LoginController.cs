using Microsoft.AspNetCore.Mvc;

namespace APIViaCep.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
