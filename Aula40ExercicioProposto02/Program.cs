using Aula40ExercicioProposto02;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioUm = new Funcionario();
            Funcionario funcionarioDois = new Funcionario();

            funcionarioUm.Nome = Console.ReadLine();
            funcionarioUm.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionarioDois.Nome = Console.ReadLine();
            funcionarioDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (funcionarioUm.Salario + funcionarioDois.Salario) / 2.0;

            Console.WriteLine(salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}