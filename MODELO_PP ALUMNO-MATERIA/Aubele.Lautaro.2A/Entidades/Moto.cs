using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aubele.Lautaro._2A
{
    public class Moto : Vehiculo
    {
        ECilindrada cilindrada;

        public Moto(string marca, EPais pais,string modelo, float precio,ECilindrada cilindrada): base(marca, pais,  modelo,  precio)
        {
            this.cilindrada = cilindrada;
        }

        public override bool Equals(object obj)
        {
            return (obj is Moto);
        }

        public override string ToString()
        {
            return ((string)this) + $"CILINDRADA: {this.cilindrada}\n";
        }

        #region Sobrecarga

        public static explicit operator Single(Moto a)
        {

            return (float)a.precio;
        }

        public static bool operator ==(Moto a, Moto b)
        {
            if (!(a is null) && !(b is null))
            {
                if ((Vehiculo)a == (Vehiculo)b && a.cilindrada == b.cilindrada)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }
        #endregion

    }
}
