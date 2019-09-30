using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using _07_Fiap.Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class PresidiarioController : Controller
    {
        private IPresidiarioRepository _repository;
        private ICelaRepository _celaRepository;

        public PresidiarioController(IPresidiarioRepository repository, ICelaRepository celaRepository)
        {
            _repository = repository;
            _celaRepository = celaRepository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _celaRepository.Listar();
            ViewBag.celas = new SelectList(lista, "CelaId", "Nome");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Presidiario presidiario)
        {
            _repository.Cadastrar(presidiario);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Listar");
        }
    }
}