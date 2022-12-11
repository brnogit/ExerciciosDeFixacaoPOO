using System;
using System.Globalization;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, numeroDePeca1, codigoPeca2, numeroDePeca2;
            double valorPeca1, valorPeca2, valorTotal;

            string[] vet = Console.ReadLine().Split();
            codigoPeca1 = int.Parse(vet[0]);
            numeroDePeca1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet1 = Console.ReadLine().Split();
            codigoPeca2 = int.Parse(vet1[0]);
            numeroDePeca2 = int.Parse(vet1[1]);
            valorPeca2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            valorTotal = (numeroDePeca1 * valorPeca1) + (numeroDePeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}