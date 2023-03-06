namespace TPIntegrador
{
    partial class btnComprarEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPelicula = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.numericEntradas = new System.Windows.Forms.NumericUpDown();
            this.labelAsientos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.textVencimientoTarjeta = new System.Windows.Forms.TextBox();
            this.textClaveTarjeta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.picturePeli = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupHorarios = new System.Windows.Forms.GroupBox();
            this.radioBtnHora3 = new System.Windows.Forms.RadioButton();
            this.radioBtnHora2 = new System.Windows.Forms.RadioButton();
            this.radiobtnHora1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeli)).BeginInit();
            this.groupHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(572, 401);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 37);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pelicula:";
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelicula.Location = new System.Drawing.Point(337, 63);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(0, 26);
            this.labelPelicula.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // numericEntradas
            // 
            this.numericEntradas.Location = new System.Drawing.Point(342, 120);
            this.numericEntradas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEntradas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEntradas.Name = "numericEntradas";
            this.numericEntradas.Size = new System.Drawing.Size(120, 20);
            this.numericEntradas.TabIndex = 4;
            this.numericEntradas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEntradas.ValueChanged += new System.EventHandler(this.numericEntradas_ValueChanged);
            // 
            // labelAsientos
            // 
            this.labelAsientos.AutoSize = true;
            this.labelAsientos.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsientos.Location = new System.Drawing.Point(208, 113);
            this.labelAsientos.Name = "labelAsientos";
            this.labelAsientos.Size = new System.Drawing.Size(96, 26);
            this.labelAsientos.TabIndex = 5;
            this.labelAsientos.Text = "Asientos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clave (CVV):";
            // 
            // textNumeroTarjeta
            // 
            this.textNumeroTarjeta.Location = new System.Drawing.Point(342, 176);
            this.textNumeroTarjeta.MaxLength = 16;
            this.textNumeroTarjeta.Name = "textNumeroTarjeta";
            this.textNumeroTarjeta.Size = new System.Drawing.Size(120, 20);
            this.textNumeroTarjeta.TabIndex = 9;
            this.textNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroTarjeta_KeyPress);
            // 
            // textVencimientoTarjeta
            // 
            this.textVencimientoTarjeta.Location = new System.Drawing.Point(342, 223);
            this.textVencimientoTarjeta.MaxLength = 4;
            this.textVencimientoTarjeta.Name = "textVencimientoTarjeta";
            this.textVencimientoTarjeta.Size = new System.Drawing.Size(50, 20);
            this.textVencimientoTarjeta.TabIndex = 10;
            this.textVencimientoTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVencimientoTarjeta_KeyPress);
            // 
            // textClaveTarjeta
            // 
            this.textClaveTarjeta.Location = new System.Drawing.Point(342, 258);
            this.textClaveTarjeta.MaxLength = 3;
            this.textClaveTarjeta.Name = "textClaveTarjeta";
            this.textClaveTarjeta.Size = new System.Drawing.Size(31, 20);
            this.textClaveTarjeta.TabIndex = 11;
            this.textClaveTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textClaveTarjeta_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Comprar entradas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto a pagar:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(337, 308);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(0, 26);
            this.labelPrecio.TabIndex = 14;
            // 
            // picturePeli
            // 
            this.picturePeli.Location = new System.Drawing.Point(586, 12);
            this.picturePeli.Name = "picturePeli";
            this.picturePeli.Size = new System.Drawing.Size(151, 186);
            this.picturePeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePeli.TabIndex = 3;
            this.picturePeli.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(586, 200);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // groupHorarios
            // 
            this.groupHorarios.Controls.Add(this.radioBtnHora3);
            this.groupHorarios.Controls.Add(this.radioBtnHora2);
            this.groupHorarios.Controls.Add(this.radiobtnHora1);
            this.groupHorarios.Location = new System.Drawing.Point(586, 361);
            this.groupHorarios.Name = "groupHorarios";
            this.groupHorarios.Size = new System.Drawing.Size(192, 34);
            this.groupHorarios.TabIndex = 17;
            this.groupHorarios.TabStop = false;
            // 
            // radioBtnHora3
            // 
            this.radioBtnHora3.AutoSize = true;
            this.radioBtnHora3.Location = new System.Drawing.Point(134, 13);
            this.radioBtnHora3.Name = "radioBtnHora3";
            this.radioBtnHora3.Size = new System.Drawing.Size(52, 17);
            this.radioBtnHora3.TabIndex = 2;
            this.radioBtnHora3.TabStop = true;
            this.radioBtnHora3.Text = "19:00";
            this.radioBtnHora3.UseVisualStyleBackColor = true;
            // 
            // radioBtnHora2
            // 
            this.radioBtnHora2.AutoSize = true;
            this.radioBtnHora2.Location = new System.Drawing.Point(76, 14);
            this.radioBtnHora2.Name = "radioBtnHora2";
            this.radioBtnHora2.Size = new System.Drawing.Size(52, 17);
            this.radioBtnHora2.TabIndex = 1;
            this.radioBtnHora2.TabStop = true;
            this.radioBtnHora2.Text = "17:00";
            this.radioBtnHora2.UseVisualStyleBackColor = true;
            // 
            // radiobtnHora1
            // 
            this.radiobtnHora1.AutoSize = true;
            this.radiobtnHora1.Location = new System.Drawing.Point(18, 14);
            this.radiobtnHora1.Name = "radiobtnHora1";
            this.radiobtnHora1.Size = new System.Drawing.Size(52, 17);
            this.radiobtnHora1.TabIndex = 0;
            this.radiobtnHora1.TabStop = true;
            this.radiobtnHora1.Text = "15:30";
            this.radiobtnHora1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "COMPRA DE ENTRADA";
            // 
            // btnComprarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupHorarios);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textClaveTarjeta);
            this.Controls.Add(this.textVencimientoTarjeta);
            this.Controls.Add(this.textNumeroTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAsientos);
            this.Controls.Add(this.numericEntradas);
            this.Controls.Add(this.picturePeli);
            this.Controls.Add(this.labelPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "btnComprarEntrada";
            this.Text = "Comprar entrada";
            this.Load += new System.EventHandler(this.btnComprarEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePeli)).EndInit();
            this.groupHorarios.ResumeLayout(false);
            this.groupHorarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelPelicula;
        public System.Windows.Forms.PictureBox picturePeli;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.NumericUpDown numericEntradas;
        private System.Windows.Forms.Label labelAsientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumeroTarjeta;
        private System.Windows.Forms.TextBox textVencimientoTarjeta;
        private System.Windows.Forms.TextBox textClaveTarjeta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupHorarios;
        private System.Windows.Forms.RadioButton radioBtnHora3;
        private System.Windows.Forms.RadioButton radioBtnHora2;
        private System.Windows.Forms.RadioButton radiobtnHora1;
        private System.Windows.Forms.Label label6;
    }
}