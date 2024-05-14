using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.Write("Nota média: " + media);
            Console.ReadKey();
        }
    }
}
