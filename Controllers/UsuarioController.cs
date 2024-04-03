using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario) 
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Dados de Login Inválidos!";
                return RedirectToAction("Login");
            }
        }
    }
}
