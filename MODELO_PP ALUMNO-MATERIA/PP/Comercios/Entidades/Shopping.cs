using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        public double PrecioExportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Exportador);
            }
        }

        public double PrecioImportadores
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Importador);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Ambos);
            }
        }


        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Shopping s)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Capacidad " + s._capacidad);
            retorno.AppendFormat("Total exportador = {0:#,###}\n", s.PrecioExportadores);
            retorno.AppendFormat("Total importador = {0:#,###}\n", s.PrecioImportadores);
            retorno.AppendFormat("Total = {0:#,###}", s.PrecioTotal);
            retorno.AppendLine();
            foreach(Comercio aux in s._comercios)
            {
                if(aux is Importador)
                {
                    retorno.AppendLine(((Importador)aux).Mostrar());
                    retorno.AppendLine();
                }
                else
                {
                    retorno.AppendLine(((Exportador)aux).Mostrar());
                    retorno.AppendLine();
                }
            }
            return retorno.ToString();
        }

        public static implicit operator Shopping(int capacidad)
        {
            return new Shopping(capacidad);
        }

        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;
            foreach(Comercio aux in s._comercios)
            {
                if(aux is Exportador && c is Exportador)
                {
                    if((Exportador)aux == (Exportador)c)
                    {
                        retorno = true;
                        break;
                    }
                    continue;
                }
                else if(aux is Importador && c is Importador)
                {
                    if ((Importador)aux == (Importador)c)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }

        public static Shopping operator +(Shopping s, Comercio c)
        {
            if (s != c)
            {
                if(s._comercios.Count < s._capacidad)
                {
                    s._comercios.Add(c);
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en el shopping!!!");
                }
            }
            else
            {
                Console.WriteLine("El comercio ya se encuentra en el shopping!!!");
            }
            return s;
        }

        private double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0d;
            foreach(Comercio aux in this._comercios)
            {
                switch (tipoComercio)
                {
                    case EComercio.Importador:
                        if (aux is Importador)
                        {
                            retorno += (Importador)aux;
                        }
                        break;

                    case EComercio.Exportador:
                        if (aux is Exportador)
                        {
                            retorno += (Exportador)aux;
                        }
                        break;

                    default:
                        if (aux is Importador)
                        {
                            retorno += (Importador)aux;
                        }
                        else
                        {
                            retorno += (Exportador)aux;
                        }
                        break;
                }
            }
            return retorno;
        }
    }
}
