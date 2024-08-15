using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ate30
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant = 30, inicio = 0;

            while(inicio <= quant)
            {
                Console.WriteLine("Número = " + inicio);
                inicio++;
            }

            Console.ReadKey();
        }
    }
}
