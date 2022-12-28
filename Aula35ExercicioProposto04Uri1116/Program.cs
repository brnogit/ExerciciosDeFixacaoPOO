using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN = 0, numeroUm = 0, numeroDois = 0 ;
            double divisao = 0.0;
            valorN = int.Parse(Console.ReadLine());

            for(int i = 0; i < valorN; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                numeroUm = int.Parse(vet[0], CultureInfo.InvariantCulture);
                numeroDois = int.Parse(vet[1], CultureInfo.InvariantCulture);

                
                if(numeroDois == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double)numeroUm / numeroDois;
                    Console.WriteLine(divisao.ToString("F1"), CultureInfo.InvariantCulture);
                }

            }
        }
    }
}