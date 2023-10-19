using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;

namespace ProjetoMVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClientesContext _context;

        public ClienteController(ClientesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contatos = _context.Clientes.ToList();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
    }
}