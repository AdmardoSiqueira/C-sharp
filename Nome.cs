using System;

public class Nome
{
	static void Main( )
	{

	string nome;				// Declara��o da Vari�vel Nome

	Console.Write("Digite seu Nome: ");

	nome = Console.ReadLine();		// L� o que foi digitado e armazena na vari�vel nome

	Console.WriteLine("Ol�! {0}", nome);	// Escreve na tela a frase e o valor que foi armazenado na vari�vel nome

	}
}
