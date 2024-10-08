﻿namespace Parcial_1_ds_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pBFondo = new PictureBox();
            tbNombre = new TextBox();
            cbSexo = new ComboBox();
            tpFecha = new DateTimePicker();
            lbNombre = new Label();
            lbSexo = new Label();
            lbNacimiento = new Label();
            tTInfo = new ToolTip(components);
            btCalcular = new Button();
            lbTitulo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pBFondo
            // 
            pBFondo.Image = Properties.Resources.Circulo_morado;
            pBFondo.Location = new Point(-184, -39);
            pBFondo.Name = "pBFondo";
            pBFondo.Size = new Size(553, 499);
            pBFondo.TabIndex = 0;
            pBFondo.TabStop = false;
            pBFondo.Tag = "Fondo";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(515, 120);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 1;
            tbNombre.Tag = "tbNombre";
            tTInfo.SetToolTip(tbNombre, "Ingrese su nombre");
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Mujer", "Hombre" });
            cbSexo.Location = new Point(515, 202);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(151, 28);
            cbSexo.TabIndex = 2;
            cbSexo.Tag = "cbSexo";
            tTInfo.SetToolTip(cbSexo, "elija su sexo");
            // 
            // tpFecha
            // 
            tpFecha.Location = new Point(515, 291);
            tpFecha.Name = "tpFecha";
            tpFecha.Size = new Size(250, 27);
            tpFecha.TabIndex = 3;
            tpFecha.Tag = "tpFecha";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(403, 93);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(162, 19);
            lbNombre.TabIndex = 4;
            lbNombre.Tag = "lbNombre";
            lbNombre.Text = "Ingrese su nombre:";
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSexo.Location = new Point(407, 182);
            lbSexo.Name = "lbSexo";
            lbSexo.Size = new Size(113, 19);
            lbSexo.TabIndex = 5;
            lbSexo.Tag = "lbSexo";
            lbSexo.Text = "Elija su sexo:";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNacimiento.Location = new Point(409, 257);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(176, 19);
            lbNacimiento.TabIndex = 6;
            lbNacimiento.Tag = "lbNacimiento";
            lbNacimiento.Text = "Fecha de nacimiento:";
            // 
            // tTInfo
            // 
            tTInfo.Tag = "tTInfo";
            // 
            // btCalcular
            // 
            btCalcular.BackColor = Color.MediumPurple;
            btCalcular.Location = new Point(546, 387);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(94, 29);
            btCalcular.TabIndex = 7;
            btCalcular.Tag = "btCalcular";
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = false;
            btCalcular.Click += btCalcular_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(301, 24);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(464, 22);
            lbTitulo.TabIndex = 9;
            lbTitulo.Tag = "lbTitulo";
            lbTitulo.Text = "Descubre tu Número de la Suerte con la Magia de Walter Mercado";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(174, 139, 203);
            pictureBox1.Image = Properties.Resources.WalterM;
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Estrellas;
            pictureBox2.Location = new Point(268, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Estrellas;
            pictureBox3.Location = new Point(759, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbTitulo);
            Controls.Add(btCalcular);
            Controls.Add(lbNacimiento);
            Controls.Add(lbSexo);
            Controls.Add(lbNombre);
            Controls.Add(tpFecha);
            Controls.Add(cbSexo);
            Controls.Add(tbNombre);
            Controls.Add(pBFondo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pBFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBFondo;
        private TextBox tbNombre;
        private ComboBox cbSexo;
        private DateTimePicker tpFecha;
        private Label lbNombre;
        private Label lbSexo;
        private ToolTip tTInfo;
        private Label lbNacimiento;
        private Button btCalcular;
        private Label lbTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
