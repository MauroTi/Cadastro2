using Cadastro2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Cadastro2.Services;

namespace Cadastro2.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly ServicoFormatador _servicoFormatador; // Injetar o serviço no controlador

        [HttpPost]
        public IActionResult Resultados(string nome, string endereco, string telefone)
        {
            // Chamar o serviço para formatar os dados
            ServicoFormatador servico = new ServicoFormatador();
            string dadosFormatados = servico.FormatarDados(nome, endereco, telefone);

            // Atribuir os dados formatados às propriedades ViewData do controlador atual
            ViewData["DadosFormatados"] = dadosFormatados;

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
