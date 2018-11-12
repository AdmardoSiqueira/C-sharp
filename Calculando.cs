using System;

public class Calculando
{
	public static void Main( )
	{

	int resultado;

	Console.Write("Informe um número: ");
	int n1 = int.Parse(Console.ReadLine());

	Console.Write("Informe um outro número: ");
	int n2 = int.Parse(Console.ReadLine());

	resultado = n1 + n2;

	Console.WriteLine(resultado);
	}
}
