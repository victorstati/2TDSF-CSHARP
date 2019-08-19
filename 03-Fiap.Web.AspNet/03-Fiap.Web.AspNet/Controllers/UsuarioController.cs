using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Simular o banco de dados
        private static IList<Usuario> _banco = new List<Usuario>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            //Enviar as informações
            ViewData["nome"] = usuario.Nome;
            ViewData["data"] = usuario.DataNascimento;
            ViewBag.endEletronico = usuario.Email;
            TempData["msg"] = "Usuário cadastrado!";

            //cadastrar no "banco"
            _banco.Add(usuario);

            //Enviar o objeto para tela
            return View(usuario);
        }

        public IActionResult Listar()
        {
            return View(_banco);
        }
    }
}