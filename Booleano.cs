using System;

public class Booleano
{
	public static void Main ()
	{

	bool validade;

	Console.Write("Informe:");
	int data = int.Parse(Console.ReadLine());

	if (data >= 2015)
	{
		validade = true;
	}
		else
		{
			validade = false;
		}

	if (validade == true)
	{
		Console.Write("Cart�o Aceito");
	}
		else
		{
			Console.Write("Cart�o Bloqueado");
		}
	}
}
