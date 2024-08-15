using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media > 5)
            {
                
                Console.Write("A média foi de " + media + ".");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Aprovado ( ^ o ^ )");
            }

            else
            {

                Console.Write("A média foi de " + media + ".");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Reprovado <( ＿ ＿ )>");
            }

            Console.ReadKey();
        }
    }
}
