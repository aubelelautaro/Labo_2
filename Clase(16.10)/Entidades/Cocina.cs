using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private double _precio;
        private bool _esIndustrial;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;
            if (!(a is null) && !(b is null))
            {
                if (a._codigo == b._codigo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return $"Código: {this._codigo} - Precio: {this._precio} - Es industrial? {this._esIndustrial}";
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Cocina)
            {
                if (this == (Cocina)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
