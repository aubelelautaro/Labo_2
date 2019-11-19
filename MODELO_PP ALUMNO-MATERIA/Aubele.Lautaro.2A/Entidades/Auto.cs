using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aubele.Lautaro._2A
{
    public class Auto : Vehiculo
    {
        ETipo tipo;

        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo):base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Auto);
        }

        public override string ToString()
        {
            return ((string)this) + $"TIPO: {this.tipo}\n";
        }

        #region Sobrecarga

        public static explicit operator Single(Auto a)
        {

            return (float) a.precio;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            if (!(a is null) && !(b is null))
            {
                if (a.tipo == b.tipo && (Vehiculo)a == (Vehiculo)b)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        #endregion
    }
}
