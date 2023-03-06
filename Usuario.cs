using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegrador
{
    public class Usuario
    {
       private string nombre;
       private string password;
       private string email;

        public Usuario(string nombre, string password, string email)
        {
            this.nombre = nombre;
            this.password = password;
            this.email = email;
        }
        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }


        public string Nombre
        {
            get { return nombre; }
            set {nombre = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        //Override al método Equals para que solo compare el nombre de usuario y contraseña al momento de loguearse
        public override bool Equals(object obj)
        {
            var usuario = obj as Usuario;
            if (usuario != null)
            {
                return usuario.Nombre == this.nombre && usuario.Password == this.password;
            }
            else
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
