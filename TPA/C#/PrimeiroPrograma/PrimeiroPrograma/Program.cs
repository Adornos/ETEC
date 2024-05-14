using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string nome;
            //Comando escreva
            Console.WriteLine("Digite seu nome: ");
            //Comando leia
            nome = Console.ReadLine();
            //Comando escreva
            Console.WriteLine("Bem vindo ao c#, " + nome);
            //Comando apertar uma tecla
            Console.ReadKey();
        }
    }
}
