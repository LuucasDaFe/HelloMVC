using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloMVC.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Status(String nome, int id)
        {
            ViewData["id"] = id;
            ViewData["nome"] = nome;
            return View();
        }

        //public string Index()
        //{
        //    return HtmlEncoder.Default.Encode("Index do WelcomeController");

        //}

        //public string Status(string nome, int id)
        //{
        //    return $"Olá {nome} e Código é: {id}, seja bem vindo :)";
        //}
    }
}
