﻿namespace Pelotita_Con_Threads
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearPelotita = new System.Windows.Forms.Button();
            this.btnPausarPelotita = new System.Windows.Forms.Button();
            this.btnReanudarPelotita = new System.Windows.Forms.Button();
            this.btnMatarPelotita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 337);
            this.panel1.TabIndex = 1;
            // 
            // btnCrearPelotita
            // 
            this.btnCrearPelotita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrearPelotita.Location = new System.Drawing.Point(12, 347);
            this.btnCrearPelotita.Name = "btnCrearPelotita";
            this.btnCrearPelotita.Size = new System.Drawing.Size(99, 23);
            this.btnCrearPelotita.TabIndex = 1;
            this.btnCrearPelotita.Text = "Crear Pelotita";
            this.btnCrearPelotita.UseVisualStyleBackColor = true;
            // 
            // btnPausarPelotita
            // 
            this.btnPausarPelotita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPausarPelotita.Location = new System.Drawing.Point(155, 347);
            this.btnPausarPelotita.Name = "btnPausarPelotita";
            this.btnPausarPelotita.Size = new System.Drawing.Size(99, 23);
            this.btnPausarPelotita.TabIndex = 2;
            this.btnPausarPelotita.Text = "Pausar Pelotita";
            this.btnPausarPelotita.UseVisualStyleBackColor = true;
            // 
            // btnReanudarPelotita
            // 
            this.btnReanudarPelotita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReanudarPelotita.Location = new System.Drawing.Point(260, 347);
            this.btnReanudarPelotita.Name = "btnReanudarPelotita";
            this.btnReanudarPelotita.Size = new System.Drawing.Size(102, 23);
            this.btnReanudarPelotita.TabIndex = 3;
            this.btnReanudarPelotita.Text = "Reanudar Pelotita";
            this.btnReanudarPelotita.UseVisualStyleBackColor = true;
            // 
            // btnMatarPelotita
            // 
            this.btnMatarPelotita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatarPelotita.ForeColor = System.Drawing.Color.Red;
            this.btnMatarPelotita.Location = new System.Drawing.Point(368, 347);
            this.btnMatarPelotita.Name = "btnMatarPelotita";
            this.btnMatarPelotita.Size = new System.Drawing.Size(99, 23);
            this.btnMatarPelotita.TabIndex = 4;
            this.btnMatarPelotita.Text = "Matar Pelotita";
            this.btnMatarPelotita.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 382);
            this.Controls.Add(this.btnMatarPelotita);
            this.Controls.Add(this.btnReanudarPelotita);
            this.Controls.Add(this.btnPausarPelotita);
            this.Controls.Add(this.btnCrearPelotita);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Pelotita Con Thread - Pausa - Reanuda - Mata";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearPelotita;
        private System.Windows.Forms.Button btnPausarPelotita;
        private System.Windows.Forms.Button btnReanudarPelotita;
        private System.Windows.Forms.Button btnMatarPelotita;
    }
}

