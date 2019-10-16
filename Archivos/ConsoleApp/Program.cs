using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MetodoUno();
            }
            catch (Exception e)
            {
                Console.WriteLine("EN EL MAIN:" +e.Message);
                Console.WriteLine("En el main: " + e.InnerException.Message);
                Console.WriteLine("EN EL main: " + e.InnerException.InnerException.Message);
                Console.WriteLine(e.StackTrace);
                try
                {
                    using (StreamWriter w = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\insidencias.log", true))
                    {
                        w.WriteLine(e.StackTrace);
                    }

                    using (StreamWriter wd = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\miArchivo.txt"))
                    {
                        wd.WriteLine(e.StackTrace);
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                }
            }

            /*try
            {
                
                using (StreamWriter w = new StreamWriter(@"C:\miCarpeta\miArchivo.txt", true))
                {

                    w.WriteLine("Lautaro Aubele");

                    w.WriteLine(DateTime.Now);
                }

                using (StreamReader r = new StreamReader("C:\\miCarpeta\\miArchivo .txt"))
                {
                    string leido;

                    while ((leido = r.ReadLine()) != null)
                    {
                        Console.WriteLine(leido);
                    }

                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.Title = "Se rompió todo";
                Console.WriteLine("No existe la ruta del archivo especificada");
            }
            catch (ArgumentException)
            {
                Console.Title = "Se rompió todo";
                Console.WriteLine("Hay caracteres no validos en la ruta del archivo especificada");
            }
            catch (FileNotFoundException)
            {
                Console.Title = "Se rompió todo";
                Console.WriteLine("No se encontro el archivo indicado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Presione alguna tecla para salir de la aplicacion");
            }
            */
            Console.ReadKey();
        }

        public static void MetodoUno()
        {
            try
            {
                MetodoDos();
            }
            catch (Exception e)
            {

                Console.WriteLine("Capturado en el metodo 1 la " + e.Message);

                throw new Exception("Excepcion del metodo 1",e);
            }
        }

        public static void MetodoDos()
        {
            try
            {
                MetodoTres();
            }
            catch (Exception e)
            {
                Console.WriteLine("Capturo en metodo 2 la " + e.Message);
                throw new Exception("Excepcion en Metodo 2",e);
            }
        }

        public static void MetodoTres()
        {
            try
            {
                MetodoCuatro();
            }
            catch (DirectoryNotFoundException e)
            {

                Console.WriteLine("Capturado en el metodo 3 la" + e.Message);
            }
        }

        public static void MetodoCuatro()
        {
            throw new MetodoCuatroException("Excepcion del Metodo 4");
        }
    }
}
