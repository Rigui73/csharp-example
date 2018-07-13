using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_example.Models
{
    public class Cliente : Persona
    {
        public Cliente(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
