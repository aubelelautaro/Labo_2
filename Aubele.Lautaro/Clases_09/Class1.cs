using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades

{
  public class Capitulo
  {
    private int numero;
    private string titulo;
    private int paginas;



    private static Random generadorDeNumeros;
    private static Random generadorDePaginas;

    public int Numero { get { return this.numero; } }
    public string Titulo { get { return this.titulo; } }
    public int Paginas { get { return this.paginas; } }

    static Capitulo()
    {
      Capitulo.generadorDeNumeros = new Random();
      Capitulo.generadorDePaginas = new Random();
    }

    private Capitulo(int num, string tit, int pag)
    {
      this.numero = num;
      this.titulo = tit;
      this.paginas = pag;
    }

    public static implicit operator Capitulo(string tit)
    {
      return new Capitulo(Capitulo.generadorDeNumeros.Next(1,16), tit,Capitulo.generadorDePaginas.Next(15,233));
    }

    public static bool operator ==(Capitulo cap1, Capitulo cap2)
    {
      bool iguales = true;

      if(!Object.Equals(cap1,null) && !(Object.Equals(cap2,null)))
      {
          if(cap1.numero == cap2.numero)
        {
          iguales = true;
        }
      }
      return iguales;
    }

    public static bool operator !=(Capitulo cap1, Capitulo cap2)
    {
      return !(cap1 == cap2);
    }


  }
}
