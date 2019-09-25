using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLLamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return 0;
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return 0;
            }
        }

        public float GananciaTotal
        {
            get
            {
                return 0;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLLamadas;
            }
        }

        private void AgregarLLamada(Llamada nuevaLLamada)
        {
            if(!Object.Equals(nuevaLLamada,null))
            {
                this._listaDeLLamadas.Add(nuevaLLamada);
            }
        }

       // private float CalcularGanancia(TipoLlamada tipo)
       // {

       // }

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa):this()
        {

        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {

        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {

        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {

        }

        public void OrdenarLLamadas()
        {

        }

        public override string ToString()
        {
            return "aaa";
        }
    }
}
