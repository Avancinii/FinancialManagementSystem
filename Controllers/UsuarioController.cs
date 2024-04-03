using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Login(int? id)
        {
            if(id != null)
            {
                if(id == 0)
                {
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario) 
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
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
