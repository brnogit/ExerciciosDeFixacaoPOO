using System;
using System.Globalization;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double formulaArea = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {formulaArea.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
