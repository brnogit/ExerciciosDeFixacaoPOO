using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN = 0;
            double realUm = 0.0, realDois = 0.0, realTres = 0.0, mediaPonderada = 0.0;


            valorN = int.Parse(Console.ReadLine());

            for(int i = 0; i < valorN; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                realUm = double.Parse(vet[0], CultureInfo.InvariantCulture);
                realDois = double.Parse(vet[1], CultureInfo.InvariantCulture);
                realTres = double.Parse(vet[2], CultureInfo.InvariantCulture);

                mediaPonderada = ((realUm * 2) + (realDois * 3) + (realTres * 5)) / 10.0 ;
                Console.WriteLine($"{mediaPonderada.ToString("F1")}");
            }

        }
    }
}