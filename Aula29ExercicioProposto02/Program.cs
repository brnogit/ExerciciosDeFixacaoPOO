using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
