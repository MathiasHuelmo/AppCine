using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegrador
{
    public class Compra
    {
        Pelicula nombrePeli;
        float precio = 1200;
        int cantidad;
        string usuario;
        public Compra(Pelicula nombrePeli,string usuario, int cantidad)
        {
            this.nombrePeli = nombrePeli;
            this.usuario = usuario;
            this.cantidad = cantidad;
            this.precio = this.precio * cantidad;
        }

        public Pelicula getNombrePeli() { return nombrePeli; }

        public float getPrecio() { return precio; }
        public string getUsuario() { return usuario; }

        public override string ToString()
        {
            return "Compraste: Pelicula: " + nombrePeli.getNombre() + " cantidad de asientos: " + cantidad + " total a pagar: " + precio + " pesos.";
        }

    }
}
