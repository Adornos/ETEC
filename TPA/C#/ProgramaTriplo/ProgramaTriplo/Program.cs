using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTriplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int triplo, numero;

            Console.Write("Digite um número a ser triplicado: ");
            numero = int.Parse(Console.ReadLine());
            triplo = numero * 3;
            Console.Write("O triplo de " + numero + " é igual a " + triplo);
            Console.ReadKey();

        }
    }
}
