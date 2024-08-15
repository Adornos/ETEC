using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            float media;
            string aluno;

            Console.Write("Digite o nome do aluno:  ");
            aluno = Console.ReadLine();
            Console.Write("Digite a média do aluno: ");
            media = float.Parse(Console.ReadLine());

            if (media>= 9)
            {
                Console.WriteLine(aluno + ": A");
            }
            else if ((media < 9) && (media >= 7.5))
            {
                Console.WriteLine(aluno + ": B");
            }
            else if ((media < 7.5) && (media >= 6))
            {
                Console.WriteLine(aluno + ": C");
            }
            else if ((media < 6) && (media >= 4))
            {
                Console.WriteLine(aluno + ": D");
            }
            else
            {
                Console.WriteLine(media + ": E");
            }

            Console.ReadKey();
        }
    }
}
