using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona yo = new Persona("Lautaro","Aubele", 41737925);

      Console.WriteLine(yo.Mostrar());

      Persona fd = new Persona("Federico", "Aubele", 36064658);

      Console.WriteLine(fd.Mostrar());

      Persona x;

      x = fd;
      Console.WriteLine(x.Mostrar());
      x.dni = 2222222;

      Console.WriteLine(fd.Mostrar());
      Console.WriteLine(x.Mostrar());

      Console.ReadKey();
    }
  }
}
