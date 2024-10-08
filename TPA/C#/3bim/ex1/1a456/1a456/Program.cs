using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a456
{
    class Program
    {
        static void Main(string[] args)
        {

            //for e while 1 a 456
            int cont = 1;
            for (int i = 1; i <= 456; i++)
            {
                Console.WriteLine(i);
            }

            while (cont<=456)
            {
                Console.WriteLine(cont);
                cont++;
            }

            Console.ReadKey();

            //for 8400 a 1
            for (int i = 8400; i >= 1; i--)
			{
                Console.WriteLine(i);
			}

            Console.ReadKey();

            //3
            Console.Write("Digite um número");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(i%2 == 0)
                {
                Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            //4
            Console.Write("Digite um número");
            n = int.Parse(Console.ReadLine());
            cont = 0;
            for (int i = 1; i <= n; i++)
            {
                cont += i;
            }
            Console.WriteLine(cont);
            Console.ReadKey();
            //5
            cont = 700;
            while (cont >= 1)
            {
                Console.WriteLine(cont);
                cont--;
            }
            Console.ReadKey();

            //6
            for (int i = 100; i >= 1; i--)
            {
                double rest = i % 2;

                if (rest != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();


        }
    }
}
