using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos { get { return this.alumnos; } }

        enum ETipoOrdenamiento
        {
            LegajoAscendente,
            LegajoDescendente,
            ApellidoAscendente,
            ApellioDescendente
        }

        public Catedra()
        {

        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);

        }
        public static bool operator -(Catedra c,Alumno a)
        {
            bool retorno = false;

            if (c == a)
            {
                retorno = c.Alumnos.Remove(a);
            }
            return retorno;

        }
        public static int operator |(Alumno a, Catedra c)
        {
            int retorno = -1;

            if (c == a)
            {
                retorno = c.Alumnos.IndexOf(a);
            }
            return retorno;
        }
        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;

            if(c != a)
            {
                retorno = true;
                c.Alumnos.Add(a);
            }
            return retorno;

        }
        public static bool operator ==(Catedra c, Alumno a)
        {
            return (!Object.Equals(c, null) && !Object.Equals(a, null) ? c.Alumnos.Contains(a) : false);
        }
    }
}
