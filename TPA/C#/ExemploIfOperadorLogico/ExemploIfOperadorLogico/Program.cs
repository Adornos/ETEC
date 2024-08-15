using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIfOperadorLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo operador lógico && = e
            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if ((numero > 20) && (numero < 50))
            {
                Console.WriteLine("O número está entre 20 e 50.");
            }
            else if ((numero >= 50) && (numero < 80))
            {
                Console.WriteLine("O número está entre 50 e 80.");
            }
            else if ((numero >= 80) && (numero < 100))
            {
                Console.WriteLine("O número está entre 80 e 100.");
            }
            else
            {
                Console.WriteLine("O numero é maior ou igual a 20 ou 190.");
            }

            Console.ReadLine();
        }
    }
}
