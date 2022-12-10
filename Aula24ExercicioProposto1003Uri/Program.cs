using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, soma;
            valorA = int.Parse(Console.ReadLine());
            valorB = int.Parse(Console.ReadLine());

            soma = valorA + valorB;

            Console.WriteLine($"SOMA = {soma}");

        }
    }
}