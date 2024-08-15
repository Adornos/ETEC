using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atevarN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, soma = 0, num;

            Console.Write("Digite um número maior que 0: ");
            cont = int.Parse(Console.ReadLine());

            while (cont == 0)
            {
                Console.WriteLine(cont);
                cont--;
            }

            
            Console.ReadKey();
        }
    }
}
