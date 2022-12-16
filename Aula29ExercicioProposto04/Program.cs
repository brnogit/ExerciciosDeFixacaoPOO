using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoDoJogo;
            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if(horaInicial >= horaFinal)
            {
                duracaoDoJogo = 24 - (horaInicial - horaFinal);
            }
            else
            {
                duracaoDoJogo = horaFinal - horaInicial;
            }

            Console.WriteLine($"O JOGO DUROU {duracaoDoJogo} HORA(S)");
        }
    }
}