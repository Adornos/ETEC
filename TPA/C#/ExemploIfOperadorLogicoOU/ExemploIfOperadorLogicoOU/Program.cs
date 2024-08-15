using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIfOperadorLogicoOU
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;

            Console.Write("Digite um a media: ");
            media = double.Parse(Console.ReadLine());

            if ((media >= 8) || (media == 7.9))
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("Aluno Aprovado");
            }



            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Aluno reprovado");
            }

            Console.ReadKey();
        }
    }
}
