using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        public string Apellido
        {
            get
            {
                return this._apellido;
            }

            set
            {
                this._apellido = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }

            set
            {
                this._legajo = value;
            }
        }

        public string Nombre
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

        public float Nota
        {
            get
            {
                return this._nota;
            }

            set
            {
                this._nota = value;
            }
        }
        #region Constructores
        public Alumno()
        {

        }

        public Alumno(string nombre):this()
        {
            this._nombre = nombre;
        }

        public Alumno(string nombre,string apellido):this(nombre)
        {
            this._apellido = apellido;
        }

        public Alumno(int legajo,string nombre,string apellido):this(nombre,apellido)
        {
            this._legajo = legajo;
        }

        public Alumno(int legajo,string nombre,string apellido,float nota):this(legajo,nombre,apellido)
        {
            this._nota = nota;
        }
        #endregion

        private string Mostrar()
        {
            return $"{this._apellido}, {this._nombre} - Legajo: {this._legajo} - Nota: {this._nota}\n";
        }

        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool retorno = false;

            if (a1._legajo == a2._legajo)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
