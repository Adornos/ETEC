﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AteN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, soma, num;

            Console.Write("Digite um número maior que 0: ");
            num = int.Parse(Console.ReadLine());

            while (cont <= num)
            {
                soma =+ cont;
                cont++;
            }

            Console.WriteLine("A soma de 0 até " + num + " é" + soma);
            Console.ReadKey();
        }
    }
}
