using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
     public class AlumnoCalificado : Alumno
    {
        protected double nota;

        public double Nota { get {return this.nota; } }

        /// LLEGA SIEMPRE NULL ALUMNO, REVISAR!!
        public AlumnoCalificado(Alumno a,double nota):base(a.Nombre,a.Apellido,a.Legajo,a.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(string nombre,string apellido,int legajo,ETipoExamen examen, double nota): this(new Alumno(nombre,apellido,legajo,examen),nota)
        {
            
        }

        private string Mostrar()
        {
            return Mostrar(this) + "Nota: " + this.nota;
        }

        public override string ToString()
        {
          return this.Mostrar();
        }
  }
}
