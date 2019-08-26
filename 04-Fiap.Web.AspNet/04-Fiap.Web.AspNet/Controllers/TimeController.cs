using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _04_Fiap.Web.AspNet.Models;
using System.Collections;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class TimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static IList _lista = new List<Time>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Cadastrar(Time time)
        {
            
            //cadastrar time no banco simulado
            _lista.Add(time);
            
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            TempData["msg"] = "Time cadastrado com sucesso!";
            return View(_lista);
        }
    }
}