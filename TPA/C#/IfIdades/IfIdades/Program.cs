using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            bool loop;

            loop = true;

            Console.Write("Digite uma idade: ");
            ano = int.Parse(Console.ReadLine());

            if ((ano >= 1) && (ano <= 5))
            {
                Console.WriteLine("Você é uma criança");
            }
            else if ((ano >= 6) && (ano <= 10))
            {
                Console.WriteLine("Você é um garotinho");
            }
            else if ((ano >= 11) && (ano <= 15))
            {
                Console.WriteLine("Você é um pré adolecesnte");
            }
            else if ((ano >= 16) && (ano <= 25))
            {
                Console.WriteLine("Você é um jovem");
            }
            else if ((ano >= 26) && (ano <= 45))
            {
                Console.WriteLine("Você é um adulto");
            }
            else if ((ano >= 46) && (ano <= 60))
            {
                Console.WriteLine("Você é um adulto experiente");
            }
            else if ((ano >= 61) && (ano <= 120))
            {
                Console.WriteLine("Você já está bem velho");
            }
            else if ((ano >= 1) && (ano <= 5))
            {
                Console.WriteLine("Você é uma criança");
            }
            else
            {
                Console.WriteLine("Espiritos não usam computador");
            }
            Console.ReadKey();
        }
    }
}
