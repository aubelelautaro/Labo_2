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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        private List<Alumno> listaDeAlumnos = new List<Alumno>();
        
        public FrmCatedra()
        {
            InitializeComponent();
            this.catedra = new Catedra();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOrdenamiento.DataSource = Enum.GetValues(typeof(Catedra.ETipoOrdenamiento));
            this.cmbOrdenamiento.SelectedIndex = 0;
            this.cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;

            
            this.btnCalificar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.DialogResult = DialogResult.Yes;

        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbOrdenamiento.SelectedIndex)
            {
                case 0:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;

                case 1:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;

                case 2:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;

                case 3:
                    this.catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
            }

            this.ActualizarListadoAlumnos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                this.btnCalificar.Enabled = true;
                this.btnModificar.Enabled = true;

                if (catedra + frmAlumno.Alumno)
                {
                    this.ActualizarListadoAlumnos();
                }else
                {
                    MessageBox.Show("No se pudo agregar el alumno","ERROR");
                }
            }
        }

        private void ActualizarListadoAlumnos()
        {
            this.lstAlumnos.Items.Clear();
            foreach(Alumno alumno in this.catedra.Alumnos)
            {
                this.lstAlumnos.Items.Add(Alumno.Mostrar(alumno));
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlumnos.SelectedIndex;

            if(index>=0)
            {
                Alumno alumno =  this.catedra.Alumnos[index];
                FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado();
                frmCalificado.ShowDialog();
                
                if(frmCalificado.DialogResult == DialogResult.OK && frmCalificado.AlumnoCalificado.Nota >5)
                {
                    this.ActualizarListadoAlumnos();
                    this.lstAlumnosCalificados.Items.Add(frmCalificado.Alumno);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlumnos.SelectedIndex;
            if (indice >=0)
            {
                FrmAlumno frmAlumno = new FrmAlumno(this.catedra.Alumnos[indice]);
                frmAlumno.ShowDialog();
                
                if(frmAlumno.DialogResult == DialogResult.OK && (this.catedra - this.catedra.Alumnos[indice]) && (this.catedra + frmAlumno.Alumno))
                {
                    this.ActualizarListadoAlumnos();
                    
                }
            }
        }
    }
}
