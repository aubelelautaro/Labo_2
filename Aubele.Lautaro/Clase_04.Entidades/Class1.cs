using System;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public string mostrar()
        {
            return $"{this.entero} - {this.cadena} - {this.fecha}\n";

        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            fecha = new DateTime(2018, 12, 9);

            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cad) : this()
        {
            this.cadena = cad;
        }

        public Cosa(string cad,DateTime fecha):this(cad)
        {
            this.fecha = fecha;
        }

        public Cosa(string cad,DateTime fecha,int entero):this(cad,fecha)
        {
            this.entero = entero;
        }
    }
}
