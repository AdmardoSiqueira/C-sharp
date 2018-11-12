using System;

public class Dobro
{
	public static void Main ()
	{

	Console.Write("Informe o valor: ");
	int valor = int.Parse(Console.ReadLine());

	double resultado = valor * 0.5;

	Console.Write("Resultado: " + resultado);

	}
}
