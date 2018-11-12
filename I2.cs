using System;

public class I2
{
	public static void Main()
	{
	Console.Write("Informe um Número: ");
	int x = int.Parse(Console.ReadLine());

	if (x >= 5)
	{
		Console.Write("O Número Informado é Maior ou Igual a5");
	}
	if (x < 5)
	{
		Console.Write("O Número Informado é Menor que 5");
	}

	}
}


