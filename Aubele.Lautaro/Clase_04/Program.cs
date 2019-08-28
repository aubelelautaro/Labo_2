using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_04.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 04";

            Cosa cosaUno = new Cosa();
            Cosa cosaDos = new Cosa("LALA");
            Cosa cosaTres = new Cosa("LALA", new DateTime(2000, 11, 28));
            Cosa cosaCuatro = new Cosa("LALA", new DateTime(1999, 04, 19), 20);

            cosaUno.EstablecerValor(DateTime.Now);
            cosaUno.EstablecerValor("AAA");
            cosaUno.EstablecerValor(19);

            Console.WriteLine(cosaUno.mostrar());
            Console.WriteLine(cosaDos.mostrar());
            Console.WriteLine(cosaTres.mostrar());
            Console.WriteLine(cosaCuatro.mostrar());

            Console.ReadKey();

        }
    }
}
