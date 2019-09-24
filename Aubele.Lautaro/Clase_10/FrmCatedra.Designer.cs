namespace Clase_10
{
    partial class FrmCatedra
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lstAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.grpAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.grpAlumnos = new System.Windows.Forms.GroupBox();
            this.grpAlumnosCalificados.SuspendLayout();
            this.grpAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(221, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(426, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(17, 261);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(484, 21);
            this.cmbOrdenamiento.TabIndex = 4;
            this.cmbOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamiento_SelectedIndexChanged);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(17, 57);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(484, 186);
            this.lstAlumnos.TabIndex = 7;
            // 
            // lstAlumnosCalificados
            // 
            this.lstAlumnosCalificados.FormattingEnabled = true;
            this.lstAlumnosCalificados.Location = new System.Drawing.Point(17, 24);
            this.lstAlumnosCalificados.Name = "lstAlumnosCalificados";
            this.lstAlumnosCalificados.Size = new System.Drawing.Size(484, 147);
            this.lstAlumnosCalificados.TabIndex = 8;
            // 
            // grpAlumnosCalificados
            // 
            this.grpAlumnosCalificados.Controls.Add(this.lstAlumnosCalificados);
            this.grpAlumnosCalificados.Location = new System.Drawing.Point(12, 306);
            this.grpAlumnosCalificados.Name = "grpAlumnosCalificados";
            this.grpAlumnosCalificados.Size = new System.Drawing.Size(514, 177);
            this.grpAlumnosCalificados.TabIndex = 9;
            this.grpAlumnosCalificados.TabStop = false;
            this.grpAlumnosCalificados.Text = "Alumno Calificados";
            // 
            // grpAlumnos
            // 
            this.grpAlumnos.Controls.Add(this.btnAgregar);
            this.grpAlumnos.Controls.Add(this.btnCalificar);
            this.grpAlumnos.Controls.Add(this.cmbOrdenamiento);
            this.grpAlumnos.Controls.Add(this.lstAlumnos);
            this.grpAlumnos.Controls.Add(this.btnModificar);
            this.grpAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grpAlumnos.Name = "grpAlumnos";
            this.grpAlumnos.Size = new System.Drawing.Size(514, 288);
            this.grpAlumnos.TabIndex = 10;
            this.grpAlumnos.TabStop = false;
            this.grpAlumnos.Text = "Alumnos";
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 495);
            this.Controls.Add(this.grpAlumnos);
            this.Controls.Add(this.grpAlumnosCalificados);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.grpAlumnosCalificados.ResumeLayout(false);
            this.grpAlumnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.ListBox lstAlumnosCalificados;
        private System.Windows.Forms.GroupBox grpAlumnosCalificados;
        private System.Windows.Forms.GroupBox grpAlumnos;
    }
}