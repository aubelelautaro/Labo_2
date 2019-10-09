using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public Llamada(string origen,string destino,float duracion)
        {
            this._duracion = duracion;
            this._nroOrigen = origen;
            this._nroDestino = destino;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            if(!Object.Equals(this,null))
            {
                sb.AppendLine($"Duracion: {this._duracion} - Origen: {this._nroOrigen} - Destino: {this._nroDestino} ");
            }else
            {
                sb.AppendLine("ERROR!");
            }

            return sb.ToString();
        }

	public static int OrdenarPorDuracionDesc(Llamada uno, Llamada dos)
        {
            return -1 *OrdenarPorDuracion(uno, dos);
        }

        public static bool operator ==(Llamada uno,Llamada dos)
        {
            bool retorno = false;
            if(!Object.Equals(uno,null) && !Object.Equals(dos, null))
            {
                if(uno is Llamada && dos is Llamada)
                {
                    if (uno._nroDestino == dos._nroDestino && uno._nroOrigen == dos.NroOrigen)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            int retorno = 0;
            if(uno._duracion>dos._duracion)
            {
                retorno = 1;
            }else if(uno._duracion <dos._duracion)
            {
                retorno =-1;
            }
            return retorno;
        }
    }
}
