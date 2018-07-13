using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_example.Models
{
    public class Banco
    {
        public string Nombre { get; set; }
        public List<Cliente> ListaClientes { get; set; }
        public Administrador Admin { get; set; }

        public Banco(Administrador admin, string nombre)
        {
            this.Nombre = nombre;
            this.Admin = admin;
            ListaClientes = new List<Cliente>();
        }
    }
}
