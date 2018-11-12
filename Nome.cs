using System;

public class Nome
{
	static void Main( )
	{

	string nome;				// Declaração da Variável Nome

	Console.Write("Digite seu Nome: ");

	nome = Console.ReadLine();		// Lê o que foi digitado e armazena na variável nome

	Console.WriteLine("Olá! {0}", nome);	// Escreve na tela a frase e o valor que foi armazenado na variável nome

	}
}
