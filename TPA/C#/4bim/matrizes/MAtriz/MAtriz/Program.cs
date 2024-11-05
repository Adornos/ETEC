using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAtriz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] universos = {"marvel", "dc", "starwars"};
            string[,] herois = {{"spiderman", "deadpool"},{"batman", "superman"},{"luke", "yoda"}};
            bool heroiValido = false;
            int indexHeroi = -1;

            Console.Write("Digite o nome de um universo: ");
            string inputUniverso = Console.ReadLine().ToLower().Trim();


            if (universos.Contains(inputUniverso))
            {
                int indexUniverso = Array.IndexOf(universos, inputUniverso);

                Console.Write("Digite o nome de um heroi dentro desse universo: ");
                string inputHeroi = Console.ReadLine().ToLower().Trim();


                for (int i = 0; i < herois.GetLength(0); i++)
                {
                    if (herois[indexUniverso, i] == inputHeroi)
                    {
                        indexHeroi = i;
                        heroiValido = true;
                        break;
                    }
                }

                if (heroiValido == true)
                {
                    Console.Write("\n    O seu heroi existe e é " + herois[indexUniverso, indexHeroi] + "\n    Pertence ao universo " + universos[indexUniverso] + "\n    Digite uma quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < quantidade; i++)
                    {
                        Console.WriteLine("        " + herois[indexUniverso, indexHeroi]);
                    }
                }
                else
                {
                    Console.WriteLine("Não há correspondencia desse heroi nesse universo");
                }
            }
            else
            {
                Console.WriteLine("\nNão há correspondência do universo");
            }

            Console.ReadKey();

        }
    }
}
