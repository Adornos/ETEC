using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            Console.WriteLine("Digite o número do mês que deseja saber o nome: ");
            ano = int.Parse(Console.ReadLine());

            switch (ano) {
                case 1:
                    Console.WriteLine("O seu mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O seu mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O seu mês é Março");
                    break;
                case 4:
                    Console.WriteLine("O seu mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("O seu mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("O seu mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("O seu mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("O seu mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("O seu mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("O seu mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("O seu mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("O seu mês é Dezembro");
                    break;
                    }

            Console.ReadKey();

            }
        }
    }