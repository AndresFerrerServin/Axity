using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MúltiplosDe3y5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Coloca el valor de n");
            n = int.Parse(Console.ReadLine());

            FizzBuzz(n);

        }

        static void  FizzBuzz(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

    }
}
