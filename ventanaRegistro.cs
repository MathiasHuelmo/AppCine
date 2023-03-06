using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class ventanaRegistro : Form
    {
        public ventanaRegistro()
        {
            InitializeComponent();
        }
        Form1 loginPrincipal = new Form1();
        private void btnRegistrar_Click(object sender, EventArgs e)

        {

            if (textNombre.Text == "" || textPass.Text == "" || textPassRepetida.Text == "" || textMail.Text == "")
            {
                MessageBox.Show("Rellene todos los campos necesarios.");
            }
            else if (textPass.Text != textPassRepetida.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir.");
                
            }
            else if (!this.textMail.Text.Contains('@')|| !this.textMail.Text.Contains('.'))
            {
                MessageBox.Show("Inserte un email válido.");
            }
            else
            {
                //Crea un usuario nuevo y lo agrega a la lista de usuarios registrados.
                Usuario user1 = new Usuario(textNombre.Text.ToLower(), textPass.Text, textMail.Text);
                loginPrincipal.usuarios.Add(user1);
                MessageBox.Show("¡Usuario creado!");      

                this.Hide();
                loginPrincipal.Show();
               
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textMail.Clear();
            textPass.Clear();
            textPassRepetida.Clear();
        }

        private void btnVerPass_Click_1(object sender, EventArgs e)
        {
            switch (textPass.UseSystemPasswordChar)
            {
                case true:
                    textPass.UseSystemPasswordChar = false;
                    break;
                case false:
                    textPass.UseSystemPasswordChar = true;
                    break;
            }

        }

        private void btnMostrarPassRepetida_Click(object sender, EventArgs e)
        {
            switch (textPassRepetida.UseSystemPasswordChar)
            {
                case true:
                    textPassRepetida.UseSystemPasswordChar = false;
                    break;
                case false:
                    textPassRepetida.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPrincipal.Show();
        }
    }
}
