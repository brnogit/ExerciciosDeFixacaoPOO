using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            numero = int.Parse(Console.ReadLine());

            if(numero >= 0 )
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}