using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN = 0, valorX = 0, valorIn = 0, valorOut = 0;

            valorN = int.Parse(Console.ReadLine());

            for(int i = 0; i < valorN; i++)
            {
                valorX = int.Parse(Console.ReadLine());

                if(valorX >= 10 && valorX <= 20)
                {
                    valorIn++;
                }
                else
                {
                    valorOut++;
                }
            }

            Console.WriteLine($"{valorIn} in");
            Console.WriteLine($"{valorOut} out");
        }
    }
}