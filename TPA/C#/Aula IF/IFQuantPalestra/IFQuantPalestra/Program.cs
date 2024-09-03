int pessoas;

Console.Write("Digete o número de pessoas: ");
pessoas = int.Parse(Console.ReadLine());

if (pessoas <= 300)
{
    Console.WriteLine("O público está baixo");
}

else if(pessoas > 300 && pessoas <= 500)
{
    Console.WriteLine("O público está razoável!");
}

else
{
    Console.WriteLine("O público está ótimo!");
}

Console.ReadLine();