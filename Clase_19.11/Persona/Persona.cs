using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;


        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public Persona(string nom,string ape,int doc)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = doc;
        }

        public string ObtenerInfo()
        {
            return $"{this.nombre} - {this.apellido} - {this.dni}";
        }

        public override string ToString()
        {
            return this.ObtenerInfo(); 
        }
    }
}
