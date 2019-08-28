using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno uno = new Alumno("A","A",1);
      Alumno dos = new Alumno("b", "b", 2);
      Alumno tres = new Alumno("C", "C", 3);

      uno.Estudiar(8, 9);
      dos.Estudiar(5, 7);
      tres.Estudiar(10, 3);

            uno.CalcularFinal();
            dos.CalcularFinal();
            tres.CalcularFinal();

            Console.WriteLine(uno.Mostrar());
            Console.WriteLine(dos.Mostrar());
            Console.WriteLine(tres.Mostrar());

            Console.ReadKey();
    }
  }
}
