using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVelocidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade;

            Console.Write("Digite a velocidade que costuma dirigir um carro: ");
            velocidade = int.Parse(Console.ReadLine());

            if (velocidade >= 75)
            {
                Console.WriteLine("Você está acima da velocidade máxima permitida");
            }

            else if ((velocidade < 75) && (velocidade > 55))
            {
                Console.WriteLine("Você está passando da velocidade máxima permitida");
            }

            else if ((velocidade <= 55) && (velocidade > 45))
            {
                Console.WriteLine("Você está na velocidade máxima permitida");
            }

            else if ((velocidade <= 45) && (velocidade >= 10))
            {
                Console.WriteLine("Você está abaixo da velocidade máxima permitida");
            }

            else
            {
                Console.WriteLine("Você não está andando");
            }

            Console.ReadKey();
        }
    }
}
