using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palestra
{
    class Program
    {
        static void Main(string[] args)
        {
            int arqui;

            Console.Write("Digite a quantidade de pessoas na palestra");
            arqui = int.Parse(Console.ReadLine());

            if (arqui <= 300)
            {
                Console.WriteLine("Publico baixo");
            }
            else if ((arqui > 300) && (arqui <= 500))
            {
                Console.WriteLine("Publico médio");
            }
            else
            {
                Console.WriteLine("Publico alto");
            }

            Console.ReadKey();
        }
    }
}