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
    public partial class FormPassOlvidada : Form
    {
        public FormPassOlvidada()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textEmail.Text == "")
            {
                MessageBox.Show("Es obligatorio rellenar todos los campos");
            }
            else if ((!this.textEmail.Text.Contains('@') || !this.textEmail.Text.Contains('.')))
            {
                MessageBox.Show("Inserte un email válido.");
            }
            else
            {
                MessageBox.Show("Le enviamos un mail para confirmar el cambio de contraseña");
                Form1 loginPrincipal = new Form1();
                loginPrincipal.Show();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 loginPrincipal = new Form1();
            loginPrincipal.Show();
            this.Close();
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnviar_Click(sender, e);
            }
        }

        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnviar_Click(sender, e);
            }
        }
    }
}
