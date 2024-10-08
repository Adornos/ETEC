using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5], sexo = new string[5];
            int[] idade = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome: ");
                nome[i] = Console.ReadLine().Trim();
                Console.Write("Digite o sexo (m) (f): ");
                sexo[i] = Console.ReadLine().Trim();
                Console.Write("Digite a idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (idade[i] > 30)
                {
                Console.WriteLine("\nPessoa: " + (i + 1) + "\n    Nome: " + nome[i] + "\n    Sexo: " + sexo[i] + "\n    Idade: " + idade[i]);
                }
            }

            Console.ReadKey();
        }
    }   
}

