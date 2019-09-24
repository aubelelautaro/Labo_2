using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10
{
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        public override Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
            set
            {
                base.txtApellido.Text = value.Apellido;
                base.txtNombre.Text = value.Nombre;
                base.txtLegajo.Text = value.Legajo.ToString();
                base.cmbTipoDeExamen.SelectedItem = value.Examen;

                base.txtApellido.Enabled = false;
                base.txtNombre.Enabled = false;
                base.txtLegajo.Enabled = false;
                base.cmbTipoDeExamen.Enabled = false;
            }
        }

        public FrmAlumnoCalificado()
        {
            InitializeComponent();

            base.txtApellido.Enabled = false;
            base.txtNombre.Enabled = false;
            base.txtLegajo.Enabled = false;
            base.cmbTipoDeExamen.Enabled = false;
            this.txtNota.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int nota;
            if (int.TryParse(this.txtNota.Text, out nota))
            {
                if (nota >= 0 && nota <= 10)
                {
                    alumno = new AlumnoCalificado(this.alumno, nota);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La nota debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
