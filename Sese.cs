using System;

public class Sese
{
	public static void Main()
	{
	Console.Write("Informe um N�mero: ");
	int x = int.Parse(Console.ReadLine());

	if (x > 5)
	{
	Console.Write("O N�mero Informado � Maior que 5");
	}
	
		if (x < 5)
		{
		Console.Write("O N�mero Informado � Menor que 5");
		}
			if (x == 5)
			{
			Console.Write("O N�mero Informado Igual a 5");
			}
	}
}

