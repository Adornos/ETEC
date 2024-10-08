using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int evogal = 0;
            for (int i = 0; i < 15; i++)
            {
           
                Console.Write("\nDigite uma letra: ");
                string letra = Console.ReadLine();
                switch (letra.ToLower())
                {
                    case "a":
                        evogal = 1;
                        break;
                    case "e":
                        evogal = 1;
                        break;
                    case "i":
                        evogal = 1;
                        break;
                    case "o":
                        evogal = 1;
                        break;
                    case "u":
                        evogal = 1;
                        break;

                    default:
                        evogal = 0;
                        break;
                }

                if (evogal == 1)
                {
                    Console.WriteLine(letra + " é vogal");
                }
                else
                {
                    Console.WriteLine(letra + " não é vogal");
                }
            }
            Console.ReadKey();
        }
    }
}
