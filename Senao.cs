using System;

public class Senao
{
	public static void Main ()
	{

	Console.Write("Informe um N�mero: ");
	int x = int.Parse(Console.ReadLine());

	if (x >= 5)
	{
		Console.Write("N�mero informando Maior ou Igual a 5");
	}
		else {
			Console.Write("N�mero informado Menor que 5");
		}
	}
}

