using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medianota
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, all;
            double numero = 5, nota,  media;

            while (numero <= 5)
            {
                Console.Write("Digite o nome do aluno: ");
                nome = Console.ReadLine();

                Console.Write("Digite a Nota A do aluno: ");
                nota = double.Parse(Console.ReadLine());

                Console.Write("Digite a Nota B do aluno: ");
                nota +=  double.Parse(Console.ReadLine());

                nota /= 2;

                Console.WriteLine("A média do aluno, " + nome + " é " + nota + "\n");
                numero++;
            }
            Console.ReadKey();
        }
    }
}
