using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if(this._lista[i].Equals(a))
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        //ver q carajo pasa aca, NO ME SACA UN AUTO
        public static bool operator -(DepositoDeAutos d,Auto a)
        {
            bool retorno = false;
            int index = d.GetIndice(a);

            if (index != -1)
            {
                d._lista.RemoveAt(index);
                retorno = true;
            }

            return retorno;
        }

       public static bool operator +(DepositoDeAutos d,Auto a)
       {
            bool retorno = false;

            if(d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
       }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad máxima: {this._capacidadMaxima}\nListado de Autos: ");
        
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
