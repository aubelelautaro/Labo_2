using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class Extensora
    {

        public static string ObtenerInfo(this PersonaExternaSellada p)
        {
            return $"{p.Nombre} - {p.Apellido} - {p.Edad} - {p.Sexo}";
        }

        public static bool EsNulo(this Object obj)
        {
            return obj is null;
        }

        public static List<Persona> ObtenerListadoBD(this Persona p)
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=LAB4PC24\\SQLEXPRESS;Initial Catalog=PersonasNuevas;Integrated Security=True");
                sql.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM [PersonasNuevas].[dbo].[Persona]", sql);


                SqlDataReader dataReader = comando.ExecuteReader();

                while(dataReader.Read())
                {
                    personas.Add(new Persona(dataReader[1].ToString(), dataReader[2].ToString(), Convert.ToInt32(dataReader[3])));
                }

                dataReader.Close();
                sql.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            return personas;
        }
    }
}
