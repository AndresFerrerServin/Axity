using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            float a, b;

            Console.WriteLine("Coloca el valor de a");
            a=float.Parse(Console.ReadLine());
            Console.WriteLine("coloca el valor de b");
            b=float.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + AddNumbers(a,b));
            Console.ReadKey();

        }

        static int AddNumbers(float a , float b)
        {
            int total;

            total = ((int)(a + b));

            return total;
        }
    }
}
