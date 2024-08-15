using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAno
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, idade, vot;
            Console.Write("Digite seu ano de nascimento: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            ano = int.Parse(Console.ReadLine());

            vot = ano - idade;

            if (vot <16)
            {
                Console.WriteLine("\nVocê está permitido a votar nas proximas eleições");
            }

            else
            {
                Console.WriteLine("\nVocê não está permitido a votar nas proximas eleições");
            }

            Console.ReadKey();
        }
    }
}
