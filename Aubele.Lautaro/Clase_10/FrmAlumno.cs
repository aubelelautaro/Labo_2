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
    public partial class FrmAlumno : Form
    {
        protected Alumno alumno;

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }
        public FrmAlumno(Alumno a):this()
        {
            this.txtApellido.Text = a.Apellido;
            this.txtNombre.Text = a.Nombre;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.cmbTipoDeExamen.Text = a.Examen.ToString();
            this.txtLegajo.Enabled = false;
        }

        public FrmAlumno()
        {
            InitializeComponent();
            this.cmbTipoDeExamen.DataSource = Enum.GetValues(typeof(Alumno.ETipoExamen));
            this.cmbTipoDeExamen.SelectedItem = Alumno.ETipoExamen.Final;
            this.cmbTipoDeExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            int auxLegajo;
            if(!String.IsNullOrEmpty(this.txtNombre.Text) && !String.IsNullOrEmpty(this.txtApellido.Text) && int.TryParse(this.txtLegajo.Text,out auxLegajo))
            {
                alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, auxLegajo, (Alumno.ETipoExamen)this.cmbTipoDeExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El formato ingresado no es correcto", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
