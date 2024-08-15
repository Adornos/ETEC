using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vogoecons
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;

            Console.Write("Digite uma letra: ");
            letra = Console.ReadLine();

            switch (letra) 
            {
                case "a":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "e":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "i":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "o":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "u":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "A":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "E":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "I":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "O":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                case "U":
                    Console.WriteLine("A letra digitada é uma vogal");
                    break;
                default:
                    Console.WriteLine("A letra digitada não é uma vogal");
                    break;
            }

            Console.ReadKey();
        }
    }
}
