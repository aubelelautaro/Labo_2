using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected string nombre;
        protected int legajo;
        protected ETipoExamen examen;

        
        public enum ETipoExamen
        {
            Primero,Segundo,Final
        }
     
        public int Legajo { get { return this.legajo;} }
        public string Apellido { get { return this.apellido;} }
        public string Nombre { get { return this.nombre;} }
        public ETipoExamen Examen { get {return this.examen ;} }


        public Alumno(string nombre,string apellido,int legajo,ETipoExamen examen)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            string retorno = "Error";
            if (!Object.Equals(a, null))
            {
              retorno = $"Nombre: {a.nombre} Apellido: {a.apellido}  Legajo: {a.legajo}  Examen: {a.examen}";
            }
            return retorno;
        }

      public static bool operator ==(Alumno a, Alumno b)
        {
            bool retorno = false;

            if(!Object.Equals(a,null) && !Object.Equals(b,null))
            {
                if(a.legajo == b.legajo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Alumno a,Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }
        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorApellidoAsc(a,b);

        }
        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;
            if (a.legajo < b.legajo)
            {
                retorno = -1;
            }
            else if (a.legajo > b.legajo)
            {
                retorno = 1;
            }
            return retorno;

        }
        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            int retorno = 0;
            if (a.legajo > b.legajo)
            {
                retorno = -1;
            }
            else if (a.legajo < b.legajo)
            {
                retorno = 1;
            }
            return retorno;

        }
    }
}
