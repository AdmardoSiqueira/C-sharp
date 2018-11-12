using System;

public class Senao
{
	public static void Main ()
	{

	Console.Write("Informe um Número: ");
	int x = int.Parse(Console.ReadLine());

	if (x >= 5)
	{
		Console.Write("Número informando Maior ou Igual a 5");
	}
		else {
			Console.Write("Número informado Menor que 5");
		}
	}
}

