using System;

public class Ponto
{
	public static void Main ()
	{
		ColocaPonto(6,10);
	}

	public static void ColocaPonto (int x, int y)
	{	
		Console.SetCursorPosition(x,y);
		Console.Write(".");
		Console.SetCursorPosition(0,20);
	}
}