using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        protected EFranja _franjaHoraria;
        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch(this._franjaHoraria)
            {
                case EFranja.Franja_1:
                    costo = (float)(0.99 * this._duracion);
                    break;
                case EFranja.Franja_2:
                    costo = (float)(1.25 * this._duracion);
                    break;
                case EFranja.Franja_3:
                    costo = (float)(0.66 * this._duracion);
                    break;
            }

            return costo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
            
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" Franja horaria: {this._franjaHoraria} - Costo: {this.CostoLLamada}");

            return Mostrar() + sb.ToString();
        }

        public Provincial(EFranja miFranja,Llamada unallamada):this(unallamada.NroOrigen,miFranja,unallamada.Duracion,unallamada.NroDestino)
        {

        }

        public Provincial(string origen,EFranja miFranja,float duracion, string destino):base(origen,destino,duracion)
        {

        }

        public override string ToString()
        {
            return Mostrar();
        }

    }
}
