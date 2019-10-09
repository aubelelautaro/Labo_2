using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get
	   {
                float ganacia = 0;
                foreach (Llamada value in this._listaDeLlamadas)
                {
                    if (value is Local)
                    {
                        ganacia += value.CostoLlamada;
                    }
                }
                return ganacia;
            }
        }

        public float GananciaPorProvincial
        {
            get
	    {
		float ganancia = 0;
                foreach (Llamada value in this._listaDeLlamadas)
                {
                    if (value is Provincial)
                    {
                        ganancia += value.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciaTotal
        {
            get
	    {
                return this.GananciaPorLocal + this.GananciaPorProvincial;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        public Centralita():this("Empresa desconocida")
        {
            
        }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
	    this._listaDeLlamadas = new List<Llamada>();
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLLamada(nuevaLlamada);

            }
            else
            {
                Console.WriteLine("Ya hay una llamada igual");
            }
            return central;

        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            if(!Object.Equals(central,null) && !Object.Equals(nuevaLlamada, null))
            {
                foreach (Llamada item in central._listaDeLlamadas)
                {
                    if(item == nuevaLlamada)
                    {
                        retorno = true;
                        break;
                    }
                }

            }
            return retorno;
        }
	
	//No sirve con el nuevo pdf q dio
        //public void OrdenarLLamadas()
        //{}

	private void AgregarLLamada(Llamada nuevaLLamada)
        {
            if(!Object.Equals(nuevaLLamada,null))
            {
                this._listaDeLlamadas.Add(nuevaLLamada);
            }
        }

        //private float CalcularGanancia(ETipoLlamada tipo)
        //{
        //    float ganancia = 0;
        //    float gananciaLocal = 0;
        //    float gananciaTotal = 0;
        //    float gananciaProv = 0;

        //    foreach (Llamada item in this._listaDeLlamadas)
        //    {
        //        if(item is Local)
        //        {
        //            gananciaLocal += ((Local)item).CostoLlamada;
        //        }
        //        else if(item is Provincial)
        //        {
        //            gananciaProv += ((Provincial)item).CostoLlamada;
        //        }
        //    }

        //    gananciaTotal = gananciaLocal + gananciaProv;

        //    switch (tipo)
        //    {
        //        case ETipoLlamada.Local:
        //            ganancia = gananciaLocal;
        //            break;
        //        case ETipoLlamada.Provincial:
        //            ganancia = gananciaProv;
        //            break;
        //        case ETipoLlamada.Todas:
        //            ganancia = gananciaTotal;
        //            break;
        //    }

        //    return ganancia;
        //}
	public float CalcularGanancia(ETipoLlamada tipo)
        {
	    float ganancia=0;
            if (tipo == ETipoLlamada.Local)
            {
                ganancia = this.GananciaPorLocal;
            }
            else if(tipo == ETipoLlamada.Provincial)
            {
                ganancia = this.GananciaPorProvincial;
            }
            else
            {
                ganancia = this.GananciaTotal;
            }
	    return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if(!Object.Equals(this,null))
            {
                sb.AppendLine(this._razonSocial);
                foreach(Llamada item in this._listaDeLlamadas)
                {
                    if(item is Local)
                    {
                        sb.Append((Local)item);
                    }
                    if(item is Provincial)
                    {
                        sb.Append((Provincial)item);
                    }
                }
            }

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
