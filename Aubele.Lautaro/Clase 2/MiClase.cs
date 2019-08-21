using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class MiClase
    {
        public static int edad;
        public static string nombre;

        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
            Console.ReadKey();
        }

        public static string MostrarNombre()
        {
            nombre="Lautaro";
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            if(nombre == MiClase.nombre)
            {
                return true;     
            }else
            {
                return false;
            }

        }
    }
}
