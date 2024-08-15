using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 5000;
            string prompt;
            bool home = true;

        while(home == true)
        {

            Console.Write("- Menu - \n - saldo: " + saldo + " \n ⬤ depositar \n ⬤ sacar \n ⬤ sair");
            
            home = false;

            Console.Write("Digite a opção: ");
            prompt = Console.ReadLine();

            switch (prompt)
            {
                case "depositar":
                    Console.Write("Digite o valor a ser depositado: ");
                    saldo =+ int.Parse(Console.ReadLine());
                    Console.WriteLine("Deposito realizado com sucesso \n Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    home = true;
                break; 
                
                default: 
                    Console.WriteLine("digite uma opção válida");
                    home = true;
                    
                break;
            }

        }
        }
    }
}
