using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aubele.Lautaro._2A
{
    public class Fabricante
    {
        #region Atributos
        private string marca;
        private EPais pais;
        #endregion

        public Fabricante(string marca,EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        #region Sobrecargas

        public static implicit operator string(Fabricante f)
        {
            return $"\nMARCA: {f.marca} - {f.pais}\n";
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            bool retorno = false;

            if(a.marca == b.marca && a.pais == b.pais)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
