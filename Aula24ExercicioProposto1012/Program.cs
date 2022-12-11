using System;
using System.Globalization;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');
            valorA = double.Parse(vet[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(vet[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = (valorA * valorC) / 2;
            circulo = 3.14159 * Math.Pow(valorC, 2);
            trapezio = ((valorA + valorB) * valorC) / 2;
            quadrado = Math.Pow(valorB, 2);
            retangulo = valorA * valorB;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
