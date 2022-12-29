using Aula40ExercicioProposto01;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            pessoa1.Nome = Console.ReadLine();
            pessoa1.Idade = int.Parse(Console.ReadLine());

            pessoa2.Nome = Console.ReadLine();
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if(pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine(pessoa1.Nome);
            }
            else
            {
                Console.WriteLine(pessoa2.Nome);
            }
        }
    }
}
