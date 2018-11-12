using System;

public class Faca
{
	public static void Main ()
	{

	int s;
	
	do {
		Console.Write("Informa a Senha: ");
		s = int.Parse(Console.ReadLine());
	}
	while (s != 1234);

	}
}