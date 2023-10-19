using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public String Description { get; set; }
        public bool Active { get; set; }
    }
}