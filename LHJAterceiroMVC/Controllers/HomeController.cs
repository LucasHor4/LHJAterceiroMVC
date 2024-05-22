using LHJAterceiroMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LHJAterceiroMVC.Controllers
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
            Fisica fisica = new Fisica
            {
                Id = 10,
                Nome = "Roberto Carlos",
                Sexo = 'M',
                CPF = 12345678910,
                RG = 12345678,
                Dig_RG = '7'
            };
            ViewData["Id"] = fisica.Id;
            ViewData["Nome"] = fisica.Nome;
            ViewData["Sexo"] = fisica.Sexo;
            ViewData["CPF"] = fisica.CPF;
            ViewData["RG"] = fisica.RG;
            ViewData["Dig_RG"] = fisica.Dig_RG;

            return View(fisica);
        }

        public IActionResult Juridica()
        {
            Juridica juridica = new Juridica();
            juridica.Id = 1074;
            juridica.Nome = "Infinity System";
            juridica.CNPJ = 17251654000157;
            juridica.IE = 12548598472;
            return View(juridica);


        }

        public IActionResult ExemploTempData() {
            Juridica juridica = new Juridica();
            juridica.Id = 1075;
            juridica.Nome = "Mamão";
            juridica.CNPJ = 17251654000158;
            juridica.IE = 12548598473;

            TempData["Id"] = juridica.Id;
            TempData["Nome"] = juridica.Nome;
            TempData["CNPJ"] = juridica.CNPJ;
            TempData["IE"] = juridica.IE;

            return RedirectToAction("juridica");

        }

        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1;
            pessoa.Nome = "Jhonatham_Joestar";
            pessoa.Sexo = 'M';
            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;
            return View(pessoa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
