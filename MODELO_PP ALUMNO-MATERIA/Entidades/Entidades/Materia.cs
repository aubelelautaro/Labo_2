using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }

            set
            {
                this._alumnos = value;
            }
        }

        public EMateria Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        #endregion


        #region Constructores
        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }

        static Materia()
        {
            _notaParaUnAlumno = new Random();
        }

        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Materia: {0}", this._nombre);
            sb.AppendLine("\n********************************");
            sb.AppendLine("*************ALUMNOS************");
            foreach(Alumno value in this._alumnos)
            {
                sb.AppendLine(Alumno.Mostrar(value));
            }

            return sb.ToString();
        }

        public void CalificarAlumnos()
        {
            foreach(Alumno value in this._alumnos)
            {
                value.Nota = _notaParaUnAlumno.Next(0,10);
            }
        }
        #endregion

        #region Sobrecargas
        public static explicit  operator String(Materia materia)
        {
            return materia.Mostrar();
        }

        public static implicit  operator float(Materia m)
        {
            float resultado = 0;
            foreach(Alumno value in m._alumnos)
            {
                resultado += value.Nota;
            }
            
            return resultado/ m._alumnos.Count();
        }

        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }


        public static bool operator !=(Materia m,Alumno a)
        {
            return !(m==a);
        }
        public static bool operator ==(Materia m, Alumno a)
        {
            bool retorno = false;
            
            if(!Object.Equals(m,null) && !Object.Equals(a,null))
            {
                foreach(Alumno value in m._alumnos)
                {
                    if(value==a)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }
        public static Materia operator +(Materia m, Alumno a)
        {
            if(m!=a)
            {
                m._alumnos.Add(a);
                Console.WriteLine("Se agregó el alumno a la materia: {0}", m._nombre);
            }else
            {
                Console.WriteLine("El alumno ya está en la materia: {0}", m._nombre);
            }
            return m;
        }
        public static Materia operator -(Materia m, Alumno a)
        {
            if(m==a)
            {
                m._alumnos.Remove(a);
                Console.WriteLine("Se quitó el alumno de la materia: {0}", m._nombre);
            }else
            {
                Console.WriteLine("El alumno no está en la materia {0}", m._nombre);
            }
            return m;
        }
        #endregion
    }
}