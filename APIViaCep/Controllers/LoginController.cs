using APIViaCep.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIViaCep.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
    {
        try  
         {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index","Home");
                }
                return View("Index");

            }


            catch (Exception erro)
            
            {
                TempData["MessagemError"] = $"Ops, não conseguimos realizar o seu login, tente novamente, detalhe do erro {erro.Message}";
                return RedirectToAction("Index");

            }

        }

    }
}
