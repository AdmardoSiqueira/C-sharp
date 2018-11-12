using System;

public class Flouti
{
	public static void Main ()
	{

	Console.Write("Informe o valor: ");
	int valor = int.Parse(Console.ReadLine());

	float f = 0.5F;
	
	float resultado = valor * f;

	Console.Write("Resultado: " + resultado);

	}
}
