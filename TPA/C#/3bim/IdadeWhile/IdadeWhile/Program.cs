using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, idade, cont = 0;

            Console.WriteLine("Digite o ano atual: ");
            ano = int.Parse(Console.ReadLine());

            while (cont < 5)
            {
                cont++;
                Console.Write("Digite o ano de nascimento da pessoa" + cont + ": ");
                idade int.Parse(Console.ReadLine());
                idade = ano-idade;
                Console.WriteLine("Idade: " + idade);
            }
        Console.ReadKey();
        }
    }
}
