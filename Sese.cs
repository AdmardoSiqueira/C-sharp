using System;

public class Sese
{
	public static void Main()
	{
	Console.Write("Informe um Número: ");
	int x = int.Parse(Console.ReadLine());

	if (x > 5)
	{
	Console.Write("O Número Informado é Maior que 5");
	}
	
		if (x < 5)
		{
		Console.Write("O Número Informado é Menor que 5");
		}
			if (x == 5)
			{
			Console.Write("O Número Informado Igual a 5");
			}
	}
}

