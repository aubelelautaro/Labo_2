using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            mensaje = ArmarFromatoMensaje();
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public static void Borrar()
        {
            mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            mensaje = ArmarFromatoMensaje();
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static string ArmarFromatoMensaje()
        {
            string aux = "";
            int i;
            for(i=0;i<mensaje.Length+2;i++)
            {
                aux += "*";
            }

            return (aux + "\n*" + mensaje + "*\n" + aux);
        }
    }
}
