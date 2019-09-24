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
        protected TextBox txtCalificacion;
        private AlumnoCalificado alumnoCalificado;
        private Alumno alumno;
        public AlumnoCalificado AlumnoCalificado { get { return this.alumnoCalificado; } }

        public FrmAlumnoCalificado():base()
        {
            InitializeComponent();
            base.txtApellido.Enabled = false;
            base.txtNombre.Enabled = false;
            base.txtLegajo.Enabled = false;
            base.cmbTipoDeExamen.Enabled = false;
        }
        public FrmAlumnoCalificado(Alumno a) : this()
        {
            this.alumno = a;
            this.txtNombre.Text = a.Nombre;
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.cmbTipoDeExamen.SelectedItem = a.Examen;
            this.txtNota.Focus();
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            txtCalificacion = txtNota;
            alumnoCalificado = new AlumnoCalificado(alumno, double.Parse(txtCalificacion.Text));
            DialogResult = DialogResult.OK;
        }

    }
}
