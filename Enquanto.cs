using System;

public class Enquanto
{
	public static void Main ()
	{

	Console.Write("Informe um Número: ");
	int n = int.Parse(Console.ReadLine());

	while (n <= 10)
	{
		Console.WriteLine(n);
		n++;
	}
}
}