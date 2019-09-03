using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        } 

        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this._tipo = tipo;
        }

        private string Mostrar()
        {
            return $"Color de tinta: {this._color}  Tipo de tinta: {this._tipo}";
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator == (Tinta uno, Tinta dos)
        { // ARREGLARLO CON EL EQUALS
            bool retorno = false;
            if(dos._color == uno._color && uno._tipo == dos._tipo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Tinta uno, Tinta dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            bool retorno = false;
            if (color == tinta._color)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta._color ==color);
        }

        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
}
