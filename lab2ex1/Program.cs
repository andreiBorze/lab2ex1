using System;

namespace lab2ex1
{
    /* Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa suma cifrelor unui numar n, n fiind citit de la tastatura. \n");

            var nr = 0;
            Console.WriteLine("Introduceti un numar:");
            bool success = int.TryParse(Console.ReadLine(), out nr);

            if (success)
            {
                Console.WriteLine("Suma cifrelor este: " + getSum(nr));
            }
            else
            {
                Console.WriteLine(" Atentie! Ai introdus si litere!");
            }         
        }

        private static Int32 getSum(int nr)
        {
            var sum = 0;

            while( nr != 0 )
            {
                sum = sum + nr % 10;
                nr = nr / 10;
            }

            return sum;
        }
    }
}
