using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Auto(string color,string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator !=(Auto a,Auto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if(!(a is null) && !(b is null))
            {
                if(a._marca == b._marca && a._color == b._marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return $"Marca: {this._marca} - Color: {this._color}";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto)
            {
                if(this == (Auto)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
