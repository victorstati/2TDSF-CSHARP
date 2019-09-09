using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CondominioController : Controller
    {
        //injeção do banco
        private BancoContext _context { get; set; }

        public CondominioController(BancoContext context)
        {
            _context = context;
        }

        //CRUD

        //Cadastrar
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Condominio condominio)
        {
            _context.Condominios.Add(condominio);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            TempData["msg"] = "Cadastrado com Sucesso!";
            var lista = _context.Condominios.ToList();
            return  View(lista);
        }

        //Editar
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var condominio = _context.Condominios.Find(id);
            return View(condominio);
        }

        [HttpPost]
        public IActionResult Editar(Condominio condominio)
        {
            _context.Attach(condominio).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }

        //Remover
        [HttpPost]
        public IActionResult Remover(int id)
        {
            var condominio = _context.Condominios.Find(id);
            _context.Condominios.Remove(condominio);
            _context.SaveChanges();

            TempData["msg"] = "Removido com Sucesso!";
            return RedirectToAction("Listar");
        }
    }
}
