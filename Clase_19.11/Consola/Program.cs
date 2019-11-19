using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using Entidades.Externa;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Entidades.Persona p = new Entidades.Persona("Lautaro", "Aubele", 41737925);

            PersonaExternaSellada PS = new PersonaExternaSellada("LAUTARO","AUBELE", 20 , Entidades.Externa.Sellada.ESexo.Masculino);

            Console.WriteLine(string.Join("\n", p.ObtenerListadoBD()));


            foreach (Entidades.Persona item in p.ObtenerListadoBD())
            {
                Console.WriteLine(item.ToString());
            }

            Object objeto = new object();

            Console.WriteLine(p.EsNulo());


            Console.WriteLine(p.ObtenerInfo());
            
            Console.WriteLine(PS.ObtenerInfo());

            Console.WriteLine(Extensora.ObtenerInfo(PS));


            Console.ReadKey();
        }
    }
}
