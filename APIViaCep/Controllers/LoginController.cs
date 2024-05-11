﻿using APIViaCep.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

                    if(loginModel.Login == "adm" && loginModel.Senha == "123")

                    return RedirectToAction("Index","Home");
                    TempData["MessagemError"] = $"Usuario e/ou senha invalido(s). Por favor, tente novamente.";
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
