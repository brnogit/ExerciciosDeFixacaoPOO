using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC, valorD, diferenca;

            valorA = int.Parse(Console.ReadLine());
            valorB = int.Parse(Console.ReadLine());
            valorC = int.Parse(Console.ReadLine());
            valorD = int.Parse(Console.ReadLine());

            diferenca = ((valorA * valorB) - (valorC * valorD));

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}