using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class FormCartelera : Form
    {
        public FormCartelera()
        {
            InitializeComponent();
        }

        private void pictureArgentina_Click(object sender, EventArgs e)
        {
            btnComprarEntrada compra = new btnComprarEntrada();
            compra.labelPelicula.Text = "ARGENTINA 1985";
            compra.picturePeli.Image = TPIntegrador.Properties.Resources.Argentina1985; 
            compra.Show();
            this.Hide();
            
        }

        private void pictureElSuplente_Click(object sender, EventArgs e)
        {
            btnComprarEntrada compra = new btnComprarEntrada();
            compra.labelPelicula.Text = "EL SUPLENTE";
            compra.picturePeli.Image = TPIntegrador.Properties.Resources.elSuplente;
            compra.Show();
            this.Hide();
        }

        private void pictureBlackAdam_Click(object sender, EventArgs e)
        {
            btnComprarEntrada compra = new btnComprarEntrada();
            compra.labelPelicula.Text = "BLACK ADAM";
            compra.picturePeli.Image = TPIntegrador.Properties.Resources.BlackAddam;
            compra.Show();
            this.Hide();
        }

        private void pictureLuzDelDiablo_Click(object sender, EventArgs e)
        {
            btnComprarEntrada compra = new btnComprarEntrada();
            compra.labelPelicula.Text = "LA LUZ DEL DIABLO";
            compra.picturePeli.Image = TPIntegrador.Properties.Resources.LaLuzDelDiablo;
            compra.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormCartelera cartelera= new FormCartelera();
            cartelera.Show();
            this.Close();
        }

        private void btnDesLogin_Click(object sender, EventArgs e)
        {
            Form1 LoginPrincipal = new Form1();
            LoginPrincipal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPerfil ventanaPerfil = new FormPerfil();
            ventanaPerfil.Show();
            this.Close();
        }
       
    }
}
