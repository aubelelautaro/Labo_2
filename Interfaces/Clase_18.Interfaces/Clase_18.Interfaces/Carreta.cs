using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Interfaces
{
    public class Carreta : Vehiculo, IARBA
    {
        public override double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Carreta(double precio):base(precio)
        {
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}
