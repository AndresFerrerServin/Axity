using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisiónBásica
{
    public class Program
    {

        public static void Main()
        {
            int n1, n2;
            Console.Write("coloca el #1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("coloca el #2:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado es: " + Division(n1, n2));
            Console.ReadLine();
        }
        static int Division(int n1, int n2)
        {
            if (n1 == 0)
                return 0;
            if (n2 == 0)
                return int.MaxValue;

            bool Negativo = false;

            if (n1 < 0)
            {
                n1 = -n1;
                if (n2 < 0)
                    n2 = -n2;
                else
                    Negativo = true;
            }
            else if (n2 < 0)
            {
                n2 = -n2;
                Negativo = true;
            }

            int cociente = 0;
            while (n1 >= n2)
            {
                n1 = n1 - n2;
                cociente++;
            }

            if (Negativo)
                cociente = -cociente;
            return cociente;
        }

        
    }
}
