namespace Clase_10
{
    partial class FrmAlumnoCalificado
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
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(16, 245);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(186, 20);
            this.txtNota.TabIndex = 20;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(13, 229);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 19;
            this.lblNota.Text = "Nota";
            // 
            // FrmAlumnoCalificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 313);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Name = "FrmAlumnoCalificado";
            this.Text = "FrmAlumnoCalificado";
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.cmbTipoDeExamen, 0);
            this.Controls.SetChildIndex(this.lblNota, 0);
            this.Controls.SetChildIndex(this.txtNota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
    }
}
