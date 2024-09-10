using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeIdSe3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int f = 1; f <= 3; f++)
			{
                Console.WriteLine("   -Pessoa " + f + "-");
                Console.Write("\nDigite o nome:");
                string nome = Console.ReadLine();
                Console.Write("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o Sexo (F) (M):");
                string sexo = Console.ReadLine();

                if ((idade >= 21) && (sexo == "m") || (sexo == "M"))
                {
                    Console.WriteLine("\nNome: " + nome + "\n");
                }

                else
                {
                    Console.WriteLine("Essa pessoa não possuí os requisitos\n");
                }

			}

            Console.ReadKey();
        }
    }
}
