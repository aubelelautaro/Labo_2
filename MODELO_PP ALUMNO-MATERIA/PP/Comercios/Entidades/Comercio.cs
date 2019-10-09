using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;

        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this(nombreComercio, new Comerciante(nombre, apellido), precioAlquiler)
        {

        }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
        }

        public int GetCantidadDeEmpleados
        {
            get
            {
                if (this._cantidadDeEmpleados == 0)
                {
                    this._cantidadDeEmpleados = Comercio._generadorDeEmpleados.Next(1, 100);
                }
                return this._cantidadDeEmpleados;
            }
        }

        private static string Mostrar(Comercio c)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Nombre Empresa: " + c._nombre);
            retorno.AppendLine("Cantidad empleados: " + c.GetCantidadDeEmpleados);
            retorno.AppendFormat("Precio alquiler: {0:#,###}\n", c._precioAlquiler);
            retorno.AppendLine("Comerciante: " + c._comerciante);
            return retorno.ToString();
        }

        public static bool operator ==(Comercio a, Comercio b)
        {
            bool retorno = false;
            if(a._nombre == b._nombre && a._comerciante == b. _comerciante)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }

        public static explicit operator string(Comercio a)
        {
            return Comercio.Mostrar(a);
        }
    }
}

 

