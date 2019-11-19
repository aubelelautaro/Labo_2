using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aubele.Lautaro._2A
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;


        public int VelocidadMaxima
        {
            get
            {
                this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 281);
                return this.velocidadMaxima;
            }

        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        private Vehiculo()
        {
          
        }

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio,string modelo,Fabricante fabri):this()
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
            this.velocidadMaxima = this.VelocidadMaxima;
        }

        public Vehiculo(string marca,EPais pais,string modelo,float precio):this(precio, modelo, new Fabricante(marca, pais))
        {

        }

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(v.fabricante);
            sb.AppendLine($"Modelo: {v.modelo}");
            sb.AppendLine($"Velocidad Maxima: {v.velocidadMaxima}");
            sb.AppendLine($"Precio: {v.precio}");
            return sb.ToString();
        }

        #region Sobrecargas
        public static explicit operator String(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            bool retorno = false;

            if(a.modelo == b.modelo && a.fabricante == b.fabricante)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }
        #endregion

    }
}
