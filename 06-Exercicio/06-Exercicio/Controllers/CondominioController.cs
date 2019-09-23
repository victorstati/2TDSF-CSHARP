using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Exercicio.Models;
using _06_Exercicio.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _06_Exercicio.Controllers
{
    public class CondominioController : Controller
    {
        //injeção do banco
        private BancoContext _context;

        public CondominioController(BancoContext context)
        {
            _context = context;
        }

        //CRUD

        [HttpGet]
        public IActionResult Pesquisar(string termoPesquisa)
        {
            var lista = _context.Condominios.Where(
                c => c.Nome.Contains(termoPesquisa)).
                Include(c => c.Sindico).ToList();
            return View("Listar", lista);
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var cond = _context.Condominios.Find(id);
            _context.Condominios.Remove(cond);
            _context.SaveChanges();
            TempData["mensagem"] = "Excluido";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cond = _context.Condominios.Include(c => c.Sindico)
                .Where(c => c.CondominioId == id).FirstOrDefault();
            return View(cond);
        }

        [HttpPost]
        public IActionResult Editar(Condominio condominio)
        {
            _context.Condominios.Update(condominio);
            _context.SaveChanges();
            TempData["mensagem"] = "Editado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            //include -> inclui o relacionamento na pesquisa
            return View(_context.Condominios.Include(c => c.Sindico).ToList());
        }

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
            TempData["mensagem"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}