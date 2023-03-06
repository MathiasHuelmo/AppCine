using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(textNombre.Text == "")
            {
                MessageBox.Show("Por favor, inserte un nombre de usuario para guardar los cambios.");
            }
            else if (!this.textEmail.Text.Contains('@') || !this.textEmail.Text.Contains('.'))
            {
                MessageBox.Show("Por favor, inserte un email válido para guardar los cambios.");

            }
            else if (textContrasena.Text == "")
            {
                MessageBox.Show("Por favor, inserte una contraseña para guardar los cambios.");
            }
            
            else
            {
                FormCartelera cartelera = new FormCartelera();
                Form1 loginPrincipal = new Form1();
                cartelera.labelUsuario.Text = textNombre.Text.ToUpper();
                MessageBox.Show("Perfil guardado con éxito.");
                cartelera.Show();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormCartelera cartelera = new FormCartelera();
            cartelera.Show();
            this.Close();
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
    }
}
