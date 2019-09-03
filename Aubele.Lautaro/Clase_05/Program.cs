using System;
using Clase_05.Entidades;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta a = new Tinta();
            string b = (string)a;

            Pluma c = new Pluma();
            b = c;
            //c = c + a;

            Console.ReadKey();
        }
    }
}
