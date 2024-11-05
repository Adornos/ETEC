using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slaman
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura;

            Console.Write("Digite a largura: ");
            largura = int.Parse(Console.ReadLine());

            if (largura % 2 == 0)
            {
                largura++;
            }




            for (int i = 0; i < largura; i++)
            {
                string copa = new string('*', i);
                string espaco = new string(' ', (largura/2));
                Console.Write(espaco);
                Console.WriteLine(copa);
                i++;
            }

            Console.ReadLine();
        }
    }
}
