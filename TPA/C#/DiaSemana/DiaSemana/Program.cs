using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Digite o dia da semana em número: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Esse dia é Domingo");
                break;

                case 2:
                    Console.WriteLine("Esse dia é Segunda-Feira");
                break;

                case 3:
                    Console.WriteLine("Esse dia é Terça-Feira");
                break;

                case 4:
                    Console.WriteLine("Esse dia é Quarta-Feira");
                break;

                case 5:
                    Console.WriteLine("Esse dia é Quinta-Feita");
                break;

                case 6:
                    Console.WriteLine("Esse dia é Sexta-Feira");
                break;

                case 7:
                    Console.WriteLine("Esse dia é Sábado");
                break;
            }
            Console.ReadKey();
        }
    }
}
