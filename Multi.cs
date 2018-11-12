using System;

public class Multi
{
	public static void Main ()
	{

	int tentativas = 0;
	bool acesso = false;
 
	while (tentativas < 5 && acesso == false)
	{
		tentativas = tentativas + 1;
		Console.WriteLine("Tentativa " + tentativas);
		Console.Write("Informe a Senha de Acesso: ");
		int senha = int.Parse(Console.ReadLine());

		if  (senha == 1234)
		{
			Console.WriteLine("Acesso Liberado");
			acesso = true;
		}
			else
			{
			Console.WriteLine("Acesso Negado");
			
				if (tentativas == 5)
				{
				Console.WriteLine("Acabaram as Tentativas. Acesso Bloqueado");
				}
			}
	}
		
	}
}