using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFPartidaFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            int arqui;

            Console.Write("Digite a quantidade de pessoas na arquibancada");
            arqui = int.Parse(Console.ReadLine());

            if (arqui <= 1000)
            {
                Console.WriteLine("Arquibancada Vazia");
            }
            else if ((arqui>1000) && (arqui<=15000))
            {
                Console.WriteLine("Arquibancada média");
            }
            else
            {
                Console.WriteLine("Arquibancada cheia");
            }

            Console.ReadKey();
        }
    }
}
