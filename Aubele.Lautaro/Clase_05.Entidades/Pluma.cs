using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "";
            this.tinta = null;
            this.cantidad = 0;
        }

        public Pluma(string marca):this()
        {
            this.marca = marca;
        }

        public Pluma(string marca,Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad):this(marca,tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $" CANTIDAD: {this.cantidad} MARCA: {this.marca} TINTA: {Tinta.Mostrar(this.tinta)}";
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Tinta tinta, Pluma p)
        {
            return (p.tinta == tinta);
        }

        public static bool operator !=(Tinta tinta, Pluma p)
        {
            return !(p.tinta == tinta);
        }

        public static Pluma operator +(Tinta tinta, Pluma p)
        {
            
            if(p.tinta == tinta && p.cantidad <100)
            {
                    p.cantidad++;
            }
            return p;
        }
    }
}
