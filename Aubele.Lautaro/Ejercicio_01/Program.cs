using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num, max=0, min=0, i;
            float promedio;

            for(i=0;i<5;i++)
            {
                Console.Write($"Ingrese numero {i + 1}: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if(i==0)
                {
                    min = num;
                    max = num;
                }else if(num>max)
                {
                    max = num;
                }else if(num<min)
                {
                    min = num;
                }
            }
            promedio = (float) sum/ i;

            Console.WriteLine($"Promedio: {promedio}\nMinimo: {min}\nMaximo: {max}");
            Console.ReadLine();

            Console.Title = "Ejercicio_01";



        }
    }
}
