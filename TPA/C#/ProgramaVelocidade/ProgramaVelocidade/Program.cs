using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaVelocidade
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, tempo, velocidade;

            Console.Write("Digite em metros, a distância percorrida por um objeto: ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Digite em minutos, o tempo que o objeto levou para percorrer: ");
            tempo = double.Parse(Console.ReadLine());

            velocidade = (distancia/1000)/(tempo/60);

            Console.Write("A velocidade escalar média desse objeto é " + velocidade + "Km/h");
            Console.ReadKey();
        }
    }
}
