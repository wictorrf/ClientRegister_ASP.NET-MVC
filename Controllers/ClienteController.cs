using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;
using ProjetoMVC.Models;

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
        [HttpPost]
        public IActionResult Criar(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
        public IActionResult Editar(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return RedirectToAction(nameof(Index));
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Editar(Clientes cliente)
        {
            var clienteBanco = _context.Clientes.Find(cliente.id);
            clienteBanco.Name = cliente.Name;
            clienteBanco.Email = cliente.Email;
            clienteBanco.Cellphone = cliente.Cellphone;
            clienteBanco.Description = cliente.Description;
            clienteBanco.Active = cliente.Active;
            _context.Clientes.Update(clienteBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detalhes(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return RedirectToAction(nameof(Index));
            return View(cliente);
        }
    }
}