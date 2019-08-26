using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {

        private static IList<Serie> _lista = new List<Serie>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

  
        public IActionResult Listar()
        {
            return View(_lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Serie serie)
        {
            _lista.Add(serie);
            TempData["msg"] = "Série Cadastrada!";
            return RedirectToAction("Listar");
        }

        
            
        
    }
}