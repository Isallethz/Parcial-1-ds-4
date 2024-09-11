namespace Parcial_1_ds_4
{
    partial class Resultado
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
            lbNumS = new Label();
            lbNumeroS = new Label();
            pictureBox1 = new PictureBox();
            lbN2 = new Label();
            lbN3 = new Label();
            lbNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbNumS
            // 
            lbNumS.AutoSize = true;
            lbNumS.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumS.Location = new Point(62, 47);
            lbNumS.Name = "lbNumS";
            lbNumS.Size = new Size(250, 19);
            lbNumS.TabIndex = 0;
            lbNumS.Tag = "lbNumS";
            lbNumS.Text = "Sus números de la suerte son:";
            // 
            // lbNumeroS
            // 
            lbNumeroS.AutoSize = true;
            lbNumeroS.Location = new Point(312, 171);
            lbNumeroS.Name = "lbNumeroS";
            lbNumeroS.Size = new Size(0, 20);
            lbNumeroS.TabIndex = 1;
            lbNumeroS.Tag = "lbNumeroS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.piramide;
            pictureBox1.Location = new Point(348, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbN2
            // 
            lbN2.AutoSize = true;
            lbN2.Location = new Point(419, 16);
            lbN2.Name = "lbN2";
            lbN2.Size = new Size(50, 20);
            lbN2.TabIndex = 3;
            lbN2.Tag = "lbN2";
            lbN2.Text = "label1";
            // 
            // lbN3
            // 
            lbN3.AutoSize = true;
            lbN3.Location = new Point(563, 170);
            lbN3.Name = "lbN3";
            lbN3.Size = new Size(50, 20);
            lbN3.TabIndex = 4;
            lbN3.Tag = "lbN3";
            lbN3.Text = "label1";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(142, 260);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(50, 20);
            lbNombre.TabIndex = 5;
            lbNombre.Tag = "lbNombre";
            lbNombre.Text = "label1";
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNombre);
            Controls.Add(lbN3);
            Controls.Add(lbN2);
            Controls.Add(pictureBox1);
            Controls.Add(lbNumeroS);
            Controls.Add(lbNumS);
            Name = "Resultado";
            Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumS;
        private Label lbNumeroS;
        private PictureBox pictureBox1;
        private Label lbN2;
        private Label lbN3;
        private Label lbNombre;
    }
}