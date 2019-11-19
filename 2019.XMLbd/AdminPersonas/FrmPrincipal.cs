using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private DataTable tablaPersonas;
        private SqlDataAdapter sqlDataAdapter;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.tablaPersonas = new DataTable("Personas");
            this.CargarDataTable();
            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                XmlTextReader xmltxt = new XmlTextReader(openFileDialog1.FileName);


                this.lista = (List<Persona>)xml.Deserialize(xmltxt);

                xmltxt.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.saveFileDialog1.ShowDialog();

                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                XmlTextWriter xmltxt = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8);

                xml.Serialize(xmltxt, this.lista);

                xmltxt.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
            this.lista = frm.Lista;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

                sql.Open();
                MessageBox.Show("Se abrió la base de datos");
                SqlCommand comando = new SqlCommand();

                comando.Connection = sql;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Personas";

                SqlDataReader dataReader = comando.ExecuteReader(); // no se puede hacer busquedas, solo va para adelante, TODOS LOS REGISTROS DE LA BASE DE DATOS VAN A ESTAR EN ESTE OBJETO, PERO SE LE UNA SOLA VEZ
                //EL EXECTUE READER TRAE TODOS LOS DATOS DEL SERVIDOR Y LA IDEA ES RECUPERARLO, PASANDOLE LOS PARAMETROS AL CONSTRUCTOR DE LA LISTA A PARTIR DE LA BASE DE DATOS
                while (dataReader.Read() != false)
                {
                    this.lista.Add(new Persona(dataReader[1].ToString(), dataReader[2].ToString(), Convert.ToInt32(dataReader[3])));

                    //MessageBox.Show($"Id: {dataReader[0].ToString()}\nNombre: {dataReader[1].ToString()}\nApellido: {dataReader[2].ToString()}\nEdad: {dataReader[3].ToString()}");
                    /*MessageBox.Show(dataReader[0].ToString()); id
                    MessageBox.Show(dataReader[1].ToString()); nombre
                    MessageBox.Show(dataReader[2].ToString()); apellido
                    MessageBox.Show(dataReader[3].ToString()); edad
                    */
                }

                comando.Connection.Close();
                dataReader.Close();
                sql.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CargarDataTable()
        {
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            
            comando.CommandText = "SELECT * FROM Personas";
            comando.Connection = sql;
            this.sqlDataAdapter = new SqlDataAdapter(comando.CommandText, sql);
            this.sqlDataAdapter.Fill(this.tablaPersonas);


            this.sqlDataAdapter.InsertCommand = new SqlCommand("INSERT INTO Personas VALUES(@p1,@p2,@p3)",sql);
            this.sqlDataAdapter.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.sqlDataAdapter.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.sqlDataAdapter.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 5, "edad");

            this.sqlDataAdapter.UpdateCommand = new SqlCommand("UPDATE Personas SET nombre = @p1,apellido = @p2,edad = @p3  WHERE id = @id ",sql);
            this.sqlDataAdapter.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.sqlDataAdapter.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.sqlDataAdapter.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 5, "edad");


            this.sqlDataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Personas WHERE id = @id",sql);



            //sql.Open();
            //SqlDataReader dataReader = comando.ExecuteReader();
            //this.tablaPersonas.Rows.Add();
            //this.tablaPersonas.Load(dataReader);
            //sql.Close();
            //comando.Connection.Close();
        }

    private void visorDataTableToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmVisorDataTable frmData = new frmVisorDataTable(this.tablaPersonas);
        frmData.Show();
    }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          try
          {
                this.sqlDataAdapter.Update(this.tablaPersonas);
                MessageBox.Show("Sincronizado");
          }
          catch (Exception exc)
          {
            MessageBox.Show(exc.Message);
          }
        }
    }
}
