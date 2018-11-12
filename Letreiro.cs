using System;

public class Letreiro
{
	public static void Main ()
	{
		ColocaPonto(8,7);
	}

	public static void ColocaPonto (int x, int y)
	{	
		Console.SetCursorPosition(x,y);
		Console.Write("Start");
		Console.SetCursorPosition(0,20);
	}
}