using System;

public class Dobro
{
	public static void Main ()
	{

	Console.Write("Informe o Sal�rio: ");
	int salario = int.Parse(Console.ReadLine());

	string valor = salario.ToString("0.00");

	Console.Write("Resultado: " + valor);

	}
}