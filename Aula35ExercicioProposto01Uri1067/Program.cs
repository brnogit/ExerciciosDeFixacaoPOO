using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX = 0;

            valorX = int.Parse(Console.ReadLine());

            for(int i = 0; i < valorX; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}