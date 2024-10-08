using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12nMmi0
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            while (cont <= 12)
            {
                cont++;
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero == 0){
                    Console.WriteLine(numero + " = 0");
                }
                else if(numero > 0){
                    Console.WriteLine(numero + " > 0");
                }

                else{
                     Console.WriteLine(numero + " < 0");
                }
            }
        }
    }
}
