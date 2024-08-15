using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doacaoSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if ((idade < 16) || (idade > 65))
            {
                Console.WriteLine("Você não pode doar sangue");
            }

            else
            {
                Console.WriteLine("Você pode doar sangue");
            }

            Console.ReadKey();
        }
    }
}
