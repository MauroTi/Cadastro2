using Cadastro2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cadastro2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Resultados(string nome, string endereco, string telefone)
        {
            // Atribuir os dados às propriedades ViewData do controlador atual
            ViewData["Nome"] = nome;
            ViewData["Endereco"] = endereco;
            ViewData["Telefone"] = telefone;

            // Retornar a visualização do controlador atual
            return View();
        }



        public IActionResult Index()
        {
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
