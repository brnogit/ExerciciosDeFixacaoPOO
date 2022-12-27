using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0, codigo = 0;

            codigo = int.Parse(Console.ReadLine());

            while(codigo != 4)
            {
                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;

                    case 2:
                        gasolina++;
                        break;

                    case 3:
                        diesel++;
                        break;

                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}