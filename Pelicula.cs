using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegrador
{
    public class Pelicula
    {
        string nombre;
        public Pelicula(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre() { return nombre; }
    }
}
