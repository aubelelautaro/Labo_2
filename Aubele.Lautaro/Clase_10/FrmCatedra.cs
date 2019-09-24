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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOrdenamiento.DataSource = Enum.GetValues(typeof(Catedra.ETipoOrdenamiento));
            this.cmbOrdenamiento.SelectedIndex = 0;
            this.cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;

            this.catedra = new Catedra();
            this.btnCalificar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.DialogResult = DialogResult.Yes;

        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.Yes)
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();

            if(frmAlumno.DialogResult == DialogResult.OK)
            {
                if(this.catedra != frmAlumno.Alumno)
                {
                    this.lstAlumnos.Items.Add(Alumno.Mostrar(frmAlumno.Alumno));
                    this.btnCalificar.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.DialogResult = DialogResult.Yes;
                }else
                {
                    MessageBox.Show("No se pudo agregar el alumno");
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
                FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado(this.catedra.Alumnos[index]);
                frmCalificado.ShowDialog();
                if(frmCalificado.DialogResult == DialogResult.OK)
                {
                    if (frmCalificado.AlumnoCalificado.Nota > 5)
                    {
                        this.lstAlumnos.Items.RemoveAt(index);
                        this.lstAlumnosCalificados.Items.Add(AlumnoCalificado.Mostrar(frmCalificado.AlumnoCalificado));
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();
            alumno.ShowDialog();
            //alumno.Legajo.Enabled = false;
            //alumno.cmbTipoDeExamen.Enabled = false;


        }
    }
}
