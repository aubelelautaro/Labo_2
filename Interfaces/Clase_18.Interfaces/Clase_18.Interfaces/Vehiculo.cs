﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Interfaces
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public abstract double Precio
        {
            get;
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

        public void MostrarPrecio()
        {
            Console.WriteLine($"Precio: {this._precio}");
        }

    }
}
