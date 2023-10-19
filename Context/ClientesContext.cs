using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
    }
}