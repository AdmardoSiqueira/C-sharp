using System;

public class I2
{
	public static void Main()
	{
	Console.Write("Informe um N�mero: ");
	int x = int.Parse(Console.ReadLine());

	if (x >= 5)
	{
		Console.Write("O N�mero Informado � Maior ou Igual a5");
	}
	if (x < 5)
	{
		Console.Write("O N�mero Informado � Menor que 5");
	}

	}
}


