using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
using Clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02";

            MiClase.MostrarEdad();
            MiClase.edad = 20;
            MiClase.MostrarEdad();

            MiClase.MostrarNombre();

            Console.WriteLine(MiClase.nombre);
            MiClase.nombre = "Federico";
            Console.WriteLine(MiClase.nombre);

            //MiClase.CompararNombres(MiClase.nombre); VER ESTO DE COMPARAR

            MiLibreria.MiClase.nombre = "LAUTARO";
   
            Console.WriteLine(MiLibreria.MiClase.MostrarNombre());

            Sello.mensaje = "Hola Mundo";
            Sello.Imprimir();
            Sello.Borrar();

            Sello.mensaje = "AHORA SOY ROJO";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Sello.mensaje = "HOLA";
            Sello.Imprimir();

            Console.ReadKey();
        }
    }
}
