using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;

        public List<Persona> Lista
        {
            get
            {
                return this.lista;
            }
        }

        public frmVisorPersona()
        {
            InitializeComponent();
        }

        public frmVisorPersona(List<Persona> lista):this()
        {
            
            this.lista = lista;
            this.ActualizarLista();

        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
                this.ActualizarLista();

                try
                {
                    SqlCommand comando = new SqlCommand();
                    SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

                    sql.Open();
                    comando.Connection = sql;
                   
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = $"INSERT INTO Personas(nombre,apellido,edad) VALUES('{frm.Persona.nombre}','{frm.Persona.apellido}',{frm.Persona.edad})";
                    comando.ExecuteNonQuery();
                    //TEXTO Q SE LE PASA AL COMMAND TEXT values('COMILLAS SIMPLES EN LOS STRING','APELLIDO',31) // listado dentro de un try catch
                    //PROBLEMA: CONCATENAR CADENA..........


                    comando.Connection.Close();
                    sql.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                
            }

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstVisor.SelectedIndex;
            if(index  >=0)
            {
                Persona per = lista[index];
                frmPersona frm = new frmPersona(per);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    this.lista.Remove(per);
                    this.lista.Add(frm.Persona);

                    try
                    {
                        SqlCommand comando = new SqlCommand();
                        SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

                        sql.Open();
                        comando.Connection = sql;

                        comando.CommandType = CommandType.Text;

                        comando.CommandText = $"UPDATE Personas SET nombre = '{frm.Persona.nombre}',apellido = '{frm.Persona.apellido}',edad = {frm.Persona.edad}  WHERE id = {index+1}";

                        comando.ExecuteNonQuery();

                        comando.Connection.Close();
                        sql.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                this.ActualizarLista();
            }
            
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            int index = this.lstVisor.SelectedIndex;

            if(index >=0)
            {
                this.lista.Remove(lista[index]);
                this.ActualizarLista();

                try
                {
                    SqlCommand comando = new SqlCommand();
                    SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

                    sql.Open();
                    comando.Connection = sql;

                    comando.CommandType = CommandType.Text;

                    comando.CommandText = $"DELETE FROM Personas WHERE id = {index + 1}";

                    comando.ExecuteNonQuery();

                    comando.Connection.Close();
                    sql.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona value in this.lista)
            {
                this.lstVisor.Items.Add(value.ToString());
            }
        }
    }
}
