﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imp_900
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 900)
            {
                if(i%2!=0)
                {
                    Console.WriteLine("contador: " + i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
