using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAr1500
{
    class Program
    {
        static void Main(string[] args)
        {
            int par, contagem = 1;
            while (contagem <= 500) 
            {
                par = contagem % 2;
                if (par == 0)
                {
                Console.WriteLine(contagem);
                contagem++;
                }
                else
                {
                    contagem++;
                }
            }
                Console.ReadKey();
        }
    }
}
