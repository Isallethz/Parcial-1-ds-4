namespace Parcial_1_ds_4
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
            pBFondo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pBFondo
            // 
            pBFondo.Image = Properties.Resources.Circulo_morado;
            pBFondo.Location = new Point(-156, -37);
            pBFondo.Name = "pBFondo";
            pBFondo.Size = new Size(553, 499);
            pBFondo.TabIndex = 0;
            pBFondo.TabStop = false;
            pBFondo.Tag = "Fondo";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(403, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 367);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pBFondo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pBFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBFondo;
        private PictureBox pictureBox1;
    }
}
