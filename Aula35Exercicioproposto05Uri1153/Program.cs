using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN = 0, fatorialN = 1;
            valorN = int.Parse(Console.ReadLine());

            for(int i = 1; i <= valorN; i++)
            {
                fatorialN *= i;
                
            }

            Console.WriteLine(fatorialN);
        }
    }
}
