string sexo;
int homens = 0;
for (int i = 1; i <= 4; i++)
{
    Console.Write("Caso " + i + "\n Digite seu Sexo (M) (F): ");
    sexo = Console.ReadLine().ToLower();
    if (sexo == "f")
    {
        Console.Write("Digite sua altura em metros: ");
        string altura = Console.ReadLine();
        Console.WriteLine("Sua altura é: " + altura + "m");
        Console.ReadKey();
        Console.Clear();
    }

    else if (sexo == "m")
    {
        homens++;
        Console.WriteLine("Você é um homem");
        Console.ReadKey();
        Console.Clear();
    }

    else
    {
        Console.WriteLine("Sexo idefinido");
        i--;
        Console.ReadKey();
        Console.Clear();
    }
}
Console.WriteLine("Houve " + homens + " homens");
Console.ReadKey();