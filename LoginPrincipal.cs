using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class Form1 : Form
    {
        public List<Usuario> usuarios = new List<Usuario>();
       
        public string nombreUsuario, password;
        FormPassOlvidada passOlvidada = new FormPassOlvidada();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {
            //Creación de una especie de bandera para que nos avise si el usuario existe
            bool usuarioExistente = false;

            //Creación del usuario admin
            Usuario admin = new Usuario("admin", "admin");
            this.usuarios.Add(admin);

            //Captura de datos del login, para luego comprobar si está en la lista
            nombreUsuario = textUsuario.Text.ToLower();
            password = textContrasena.Text;
            Usuario user1 = new Usuario(nombreUsuario, password);
            //Recorrido de lista usuarios para comprobar si los datos son existentes y correctos
            foreach (var user in usuarios)
            {
                bool bandera = user.Equals(user1);
                if (bandera)
                {
                    usuarioExistente = true;
                }
            }

            //Condición para el logueo, si el usuario y contra coincide con el existente, entrará al IF, sino al ELSE
            if (usuarioExistente)
            {
                MessageBox.Show("¡Bienvenido " + nombreUsuario + "!");
                FormCartelera cartelera = new FormCartelera();
                this.Hide();
                cartelera.Show();
                cartelera.labelUsuario.Text = nombreUsuario.ToUpper();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLoginEntrar_Click(sender, e);
            }
        }
        private void textContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLoginEntrar_Click(sender, e);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ventanaRegistro ventanaReg = new ventanaRegistro();
            ventanaReg.Show();
            this.Hide();

        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            switch (textContrasena.UseSystemPasswordChar)
            {
                case true:
                    textContrasena.UseSystemPasswordChar = false;
                    break;
                case false:
                    textContrasena.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void labelOlvidaContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passOlvidada.Show();
            this.Hide();
        }

        private void linkLabelPassOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passOlvidada.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
