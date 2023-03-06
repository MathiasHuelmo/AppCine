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
    public partial class btnComprarEntrada : Form
    {
        float precio = 1200;
        public btnComprarEntrada()
        {
            InitializeComponent();
        }
        FormCartelera cartelera = new FormCartelera();
        Form1 LoginPrincipal = new Form1();
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            cartelera.Show();
            this.Hide();
        }

        private void textNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textVencimientoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            textNumeroTarjeta_KeyPress(sender,e);
        }

        private void textClaveTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            textNumeroTarjeta_KeyPress(sender, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textNumeroTarjeta.Text != "" && textClaveTarjeta.Text != "" && textVencimientoTarjeta.Text != "")
            {
                if (textNumeroTarjeta.Text.Length < 16)
                {
                    MessageBox.Show("Por favor, inserte un número de tarjeta válido");
                }
                else if (textVencimientoTarjeta.Text.Length < 4)
                {
                    MessageBox.Show("Por favor, inserte una fecha de vencimiento válida.");
                }
                else if (textClaveTarjeta.Text.Length < 3)
                {
                    MessageBox.Show("Por favor, inserte una clave válida.");
                }
              
                else
                {
                    if(radiobtnHora1.Checked || radioBtnHora2.Checked || radioBtnHora3.Checked)
                    {
                        Compra compra = new Compra(new Pelicula(labelPelicula.Text), LoginPrincipal.nombreUsuario, ((int)numericEntradas.Value));
                        MessageBox.Show(compra.ToString());
                        this.Close();
                        cartelera.Show();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione uno de los horarios disponibles.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene los espacios en blanco para realizar la compra");
            }
        }

        private void btnComprarEntrada_Load(object sender, EventArgs e)
        {
            labelPrecio.Text = precio.ToString() + " pesos.";
        }

        private void numericEntradas_ValueChanged(object sender, EventArgs e)
        {
            int cant_entradas = (int)numericEntradas.Value;
            labelPrecio.Text = (precio * cant_entradas).ToString()+ " pesos.";
        }
    }
}
