using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
  public class Libro
  {
    private string titulo;
    private string autor;
    private List<Capitulo> capitulos;

    public string Titulo{ get{ return this.titulo; }}
    public string Autor{ get{ return this.autor; }}

    public Libro(string tit, string aut)
    {
      this.titulo = tit;
      this.autor = aut;
      this.capitulos = new List<Capitulo>();
    }

    public int CantidadDePaginas
    {
      get
      {
        int cant=0;
        foreach(Capitulo value in this.capitulos)
        {
          cant += value.Paginas;
        }
        return cant;
      }
    }

    public int CantidadDeCapitulos
    {
      get
      {
        return this.capitulos.Count;
      }
    }
    public Capitulo this[int i]
    {
      get
      {
        int cant = this.capitulos.Count;
        if (i < 0 || i > cant)
        {
          return null;
        }
        else
        {
          return capitulos[i];
        }
      }
      set
      {
        int cant = this.capitulos.Count;
        if(i<0 || i>=cant)
        {
          this.capitulos.Add(value);
        }else
        {
          this.capitulos[i] = value;
        }
      }
    }
  }
}
