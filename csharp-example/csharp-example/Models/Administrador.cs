using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_example.Models
{
    public class Administrador : Persona
    {
        public Administrador(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
