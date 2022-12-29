using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroN = 0, quadrado = 0, cubo = 0;
            numeroN = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numeroN; i++)
            {
                quadrado = i * i;
                cubo = quadrado * i;

                Console.WriteLine($"{i} {quadrado} {cubo}");
                
            }
        }
    }
}