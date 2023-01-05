using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula45ExercicioProposto03
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Status()
        {
            if(NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }

        public double Pontos()
        {
                return 60 - NotaFinal();

        }
    }
}
