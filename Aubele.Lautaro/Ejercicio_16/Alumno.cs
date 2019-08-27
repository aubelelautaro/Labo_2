using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
  class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;

    public string nombre;
    public string apellido;
    public int legajo;

    public void CalcularFinal()
    {
      if(this.nota1 > 3 && this.nota2 >3 )
      {
        Random nota = new Random();
        this.notaFinal = (Single)nota.Next(1, 10);
      }
      else
      {
        notaFinal = -1;
      }

    }

    public void Estudiar(byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }

    public string Mostrar()
    {
      if(this.notaFinal >0)
      {
        return this.nombre + " - " + this.apellido + " - " + this.legajo.ToString() + this.notaFinal.ToString(); 
      }
      else
      {

      }
    }

    public Alumno(string nombre, string apellido, int legajo)
    {
      this.apellido = apellido;
      this.nombre = nombre;
      this.legajo = legajo;
    }
  }
}
