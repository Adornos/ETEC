using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whilepares
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, cont = 100;

            while (cont >= 0)
            {
                resto = cont % 2;

                if (resto == 0) 
                {
                    Console.WriteLine(cont);
                    cont--;
                }

                else
                {
                    cont--;
                }

            }
                Console.ReadKey();
        }
    }
}
