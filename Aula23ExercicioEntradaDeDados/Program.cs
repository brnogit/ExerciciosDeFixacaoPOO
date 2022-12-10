using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, ultimoNome;
            int quartos, idade;
            double precoDoProduto, altura;

            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com o preço de um produto: ");
            precoDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Entre com seu último nome, idade e altura(na mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine();
            ultimoNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"{nomeCompleto}");
            Console.WriteLine($"{quartos}");
            Console.WriteLine($"{precoDoProduto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{ultimoNome}");
            Console.WriteLine($"{idade}");
            Console.WriteLine($"{altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}