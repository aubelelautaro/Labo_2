using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
  public partial class frmVisorDataTable : frmVisorPersona
  {
    public DataTable miDataTable;

    public frmVisorDataTable() : base()
    {
      InitializeComponent();
      this.miDataTable = new DataTable();
    }

    public frmVisorDataTable(DataTable data) : this()
    {
      this.miDataTable = data;
      this.ActualizarLista();
    }

    public DataTable MiDataTable
    {
      //get => miDataTable;
      get
      {
        return this.miDataTable;
      }
    }

    private void ActualizarLista()
    {
      this.lstVisor.Items.Clear();
      foreach (DataRow dr in miDataTable.Rows)
      {
        MessageBox.Show(dr.RowState.ToString());
        if(dr.RowState != DataRowState.Deleted)
        {
          this.lstVisor.Items.Add($"{dr[0]} - {dr[1]} - {dr[2]} - {dr[3]}");
        }
      }
    }

    
    protected override void btnAgregar_Click(object sender, EventArgs e)
    {
      frmPersona frm = new frmPersona();
      if(frm.ShowDialog() == DialogResult.OK)
      {
        DataRow fila = this.miDataTable.NewRow();

        fila[0] = this.miDataTable.Rows.Count + 1;
        fila[1] = frm.Persona.nombre;
        fila[2] = frm.Persona.apellido;
        fila[3] = frm.Persona.edad;
        this.miDataTable.Rows.Add(fila);
        this.ActualizarLista();
      }
    }

    protected override void btnModificar_Click(object sender, EventArgs e)
    {
      if(lstVisor.SelectedIndex>=0)
      {
        DataRow fila = this.miDataTable.Rows[this.lstVisor.SelectedIndex];
        //TIRA EL ERROR Q ME EXPLICO EL PROFESOR CON EL  DR.ROWSTATE QUE ESTA BORRADO CUANDO AGREGO Y ELIMINO
        frmPersona frm = new frmPersona(new Entidades.Persona(fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3])));
        frm.StartPosition = FormStartPosition.CenterScreen;

        if (frm.ShowDialog() == DialogResult.OK)
        {
          fila[1] = frm.Persona.nombre;
          fila[2] = frm.Persona.apellido;
          fila[3] = frm.Persona.edad;
        }
        this.ActualizarLista();
      } 
    }

    protected override void btnEliminar_Click(object sender, EventArgs e)
    {
      if (lstVisor.SelectedIndex >= 0)
      {
        DataRow fila = this.miDataTable.Rows[this.lstVisor.SelectedIndex];
          fila.Delete();
        this.ActualizarLista();
      }
    }
  }
}
