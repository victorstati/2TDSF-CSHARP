using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using _07_Fiap.Web.AspNet.Repositories;
using _07_Fiap.Web.AspNet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class CelaController : Controller
    {

        private ICelaRepository _repository;
        private IPresidiarioRepository _presidiarioRepository;
        public CelaController(ICelaRepository repository, IPresidiarioRepository presidiarioRepository)
        {
            _repository = repository;
            _presidiarioRepository = presidiarioRepository;
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            _repository.Cadastrar(cela);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_repository.Listar());
        }

        [HttpGet]
        public IActionResult Detalhar(int codigo)
        {
            //Pesquisar a cela
            var cela = _repository.BuscarPorCodigo(codigo);
            //Listar os presidiários
            var presidiarios = _presidiarioRepository.BuscarPor(p => p.CelaId == codigo);

            //objeto que possui todas as informações da tela
            var viewModel = new DetalheCelaViewModel()
            {
                Cela = cela,
                Presidiarios = presidiarios,
                QuantidadePresidiarios = presidiarios.Count,
                Ocupacao = (presidiarios.Count * 100) / cela.QuantidadeMaxima
            };
            return View(viewModel);
        }
    }
}