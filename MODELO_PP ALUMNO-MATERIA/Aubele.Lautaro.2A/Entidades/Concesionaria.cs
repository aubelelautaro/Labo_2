using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aubele.Lautaro._2A
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public double PrecioDeAutos
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioDeAutos);
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioDeMotos);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EVehiculo.PrecioTotal);
            }
        }

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool retorno = false;
            if (!(c is null) && !(v is null))
            {
                foreach (Vehiculo item in c.vehiculos)
                {

                    if (item is Auto && v is Auto)
                    {
                        if((Auto)item == (Auto)v)
                        {
                            retorno = true;
                        }
                        
                    }

                    if (item is Moto && v is Moto)
                    {
                        if ((Moto)item == (Moto)v)
                        {
                            retorno = true;
                        }
                    }
                }

            }
            return retorno;
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if (c.capacidad > c.vehiculos.Count)
            {
                if (c == v)
                {
                    Console.WriteLine("El vehículo ya esta en la concesionaria!!!");
                }
                else
                {
                    c.vehiculos.Add(v);
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la concesionaria!!!");
            }

            return c;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();
            if (!Object.Equals(c, null))
            {
                sb.AppendLine($"Capacidad: {c.capacidad}");
                sb.AppendLine($"Total por Autos: {c.PrecioDeAutos}");
                sb.AppendLine($"Total por motos: {c.PrecioDeMotos}");
                sb.AppendLine($"Total: {c.PrecioTotal}");
                sb.AppendLine("******************************************************");
                sb.AppendLine("Listado de Vehículos");
                sb.AppendLine("******************************************************");
                foreach (Vehiculo item in c.vehiculos)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            float ganancia = 0;
            float gananciaMoto = 0;
            float gananciaAuto = 0;
            float gananciaTotal = 0;

            foreach (Vehiculo item in this.vehiculos)
            {
                if (item is Auto)
                {
                    gananciaAuto += ((Auto)item).Precio;
                }
                else if (item is Moto)
                {
                    gananciaMoto += ((Moto)item).Precio;
                }
            }

            gananciaTotal = gananciaAuto + gananciaMoto;

            switch (tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    ganancia = gananciaAuto;
                    break;
                case EVehiculo.PrecioDeMotos:
                    ganancia = gananciaMoto;
                    break;
                case EVehiculo.PrecioTotal:
                    ganancia = gananciaTotal;
                    break;
            }
            return ganancia;
        }

    }
}