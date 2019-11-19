using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades
{
    public class PersonaHerencia : PersonaExterna
    {
        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public PersonaHerencia(string nom, string ape, int edad, ESexo sex) : base(nom, ape, edad, sex)
        {

        }

        public string ObtenerInfo()
        {
            return $"{this._nombre} - {this._apellido} - {this._edad} - {this._sexo}";
        }

        ///METODOS DE EXTENSION... si se quiere obtener ObtenerInfo de nuestra clase sellada se genera el metodo siguiendo algunas reglas, el metodo debe estar dentro de una clase marcada como estatica ( todos sus metodos deben ser estaticos)
    }
}
