using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return base._duracion * this._costo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public Local(Llamada unaLLamada,float costo):this(unaLLamada.NroOrigen,unaLLamada.Duracion,unaLLamada.NroDestino,costo)
        {

        }

        public Local(string origen,float duracion,string destino,float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Costo: {this.CostoLLamada}");
            return base.Mostrar() + sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
