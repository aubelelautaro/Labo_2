using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos { get { return this.alumnos; } }

        public enum ETipoOrdenamiento
        {
            LegajoAscendente,LegajoDescendente,ApellidoAscendente,ApellidoDescendente
        }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
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
                retorno = true;
                c.Alumnos.Remove(a);
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
            bool retorno = false;
            if (!Object.Equals(c, null) && !Object.Equals(a, null))
            {
                foreach(Alumno value in c.alumnos)
                {
                    if(value == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

    public override string ToString()
    {
      string mensaje = " ";
      foreach(Alumno actual in this.alumnos)
      {
        
        mensaje += actual.ToString();
        mensaje += "\n";
      }
      return mensaje;
    }
  }
}
