using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        private int GetIndice(T a)
        {
            return this._lista.IndexOf(a);
        }

        //ver q carajo pasa aca
        public static bool operator -(Deposito<T> d, T a)
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

        public static bool operator +(Deposito<T> d,T a)
        {
            bool retorno = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad máxima: {this._capacidadMaxima}\nListado de {typeof(T).Name}: ");

            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
