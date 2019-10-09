using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador : Comercio
    {
        public ETipoProducto tipo;

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo) : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine((string)this);
            retorno.AppendLine("Tipo: " + this.tipo);
            return retorno.ToString();
        }

        public static bool operator ==(Exportador a, Exportador b)
        {
            bool retorno = false;
            if(a.tipo == b.tipo && (Comercio)a == (Comercio)b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }

        public static implicit operator float(Exportador a)
        {
            return a._precioAlquiler;
        }
    }
}
