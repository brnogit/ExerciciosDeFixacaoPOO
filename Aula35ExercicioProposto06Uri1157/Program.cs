using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN;
            valorN = int.Parse(Console.ReadLine());

            for(int i = 1; i  <= valorN; i++)
            {
                if(valorN % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}