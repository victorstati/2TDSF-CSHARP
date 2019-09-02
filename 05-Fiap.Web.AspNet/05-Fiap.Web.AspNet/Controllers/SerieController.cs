using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {
        //Tipo o "em", vai acessar as coisas no banco
        private BancoContext _context;

        //O contexto será instanciando pelo framework
        public SerieController(BancoContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult Listar()
        {
            TempData["msg"] = "Cadastrado";
            var lista = _context.Series.ToList();
            return View(lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Serie serie)
        {
            _context.Series.Add(serie);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
            
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar a serie no BD
            var serie = _context.Series.Find(id);
            //Retornar a view com a serie que será atualizada
            return View(serie);
        }

        [HttpPost]
        public IActionResult Editar(Serie serie)
        {
            TempData["msg"] = "Atualizado!";
            _context.Attach(serie).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }
        
        public IActionResult Remover(Serie serie)
        {
            _context.Series.Remove(serie);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }

        /*Entity Framework:
         * criar calsse que herda de dbContext
         * configurar o banco de dados appsettings.json
         * configurar a injeção de dependência na startup.cs
        */ 
    }
}