using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConteoDeRepetición
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8,1,3,1,4,5,6,3,2};
            int contador = CountDuplicates(numbers);
            Console.WriteLine("El conteo de repeticiones es: " + contador);
            Console.ReadKey();
        }

        static int CountDuplicates(int[] numbers)
        {
            int contador = 0;
 
                Array.Sort(numbers);

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        contador++;
                    }
                }
  
            return contador;
            
        }

    }
}
