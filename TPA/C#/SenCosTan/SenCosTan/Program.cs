using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenCosTan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            List<double> resultado = new List<double>();

            Console.Write("Escreva a medida do cateto oposto desse tringulo: ");
            notas.Add(double.Parse(Console.ReadLine()));
            
            Console.Write("Escreva a medida do cateto adjacente desse tringulo: ");
            notas.Add(double.Parse(Console.ReadLine()));

            Console.Write("Escreva a medida do hiponetusa desse tringulo: ");
            notas.Add(double.Parse(Console.ReadLine()));

            resultado.Add(notas[0] / notas[2]);
            resultado.Add(notas[1] / notas[2]);
            resultado.Add(notas[0] / notas[1]);

            Console.WriteLine("\n  O seno desse tringulo é " + resultado[0] + "\n  O cosseno desse tringulo é " + resultado[1] + "\n  A tangente desse tringulo é " + resultado[2]);
            Console.ReadKey();         



        }
    }
}
