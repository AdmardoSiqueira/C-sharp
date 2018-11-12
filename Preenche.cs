using System;

public class Preenche
{
	public static void Main ()
	{

	int[] v = new int[10];

		for (int i = 0; i < 10; i++)			
		{
			Console.WriteLine("Informe o Valor da Posição: {0}", i);
			v[i] = int.Parse(Console.ReadLine());
		}
	}
}
