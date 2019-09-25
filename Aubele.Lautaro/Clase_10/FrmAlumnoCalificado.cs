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
        private AlumnoCalificado alumnoCalificado;
        private Alumno alumno;
        public AlumnoCalificado AlumnoCalificado { get { return this.alumnoCalificado; } }

        public FrmAlumnoCalificado()
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
            base.txtNombre.Text = a.Nombre;
            base.txtApellido.Text = a.Apellido;
            base.txtLegajo.Text = a.Legajo.ToString();
            base.cmbTipoDeExamen.SelectedItem = a.Examen;

        }
        /// falta sacar el alumno de la catedra al ponerle nota y mostrar la nota.

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            double num;

            if(double.TryParse(this.txtNota.Text, out num))
            {
                this.alumnoCalificado = new AlumnoCalificado(this.alumno, num);
                DialogResult = DialogResult.OK;
            }
            
        }

    }
}
