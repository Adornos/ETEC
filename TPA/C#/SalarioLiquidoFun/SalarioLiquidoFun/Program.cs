using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioLiquidoFun
{
    class Program
    {
        static void Main(string[] args)
        {
            double salLiq, horasT, valHora, salBrt;
            
            Console.Write("Digite o valor da hora: ");
            valHora = double.Parse(Console.ReadLine());
            Console.Write("Digite quantas horas o funcionário trabalhou: ");
            horasT = double.Parse(Console.ReadLine());

            salBrt = horasT * valHora;

            if (salBrt > 4000) 
            {
                salLiq = salBrt - (salBrt*10) / 100;
                Console.WriteLine("O salário liquido será de: " + salLiq);
            }

            else if ((salBrt <= 4000) && (salBrt > 1000))
            {
                salLiq = salBrt - (salBrt*7) / 100;
                Console.WriteLine("O salário liquido será de: " + salLiq);
            }

            else
            {
                salLiq = salBrt - (salBrt*5) / 100;
                Console.WriteLine("O salário liquido será de: " + salLiq);
            }

            Console.ReadKey();
        }
    }
}
