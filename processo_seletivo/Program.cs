using System;
using processo_seletivo.model;

namespace processo_seletivo
{
	class Program
	{
		static void Main(string[] args)
		{
			// instancia um objeto do tipo Fatorial
			Fatorial fat1 = new Fatorial();
			// pede que o usuario entre com um valor para calcular o fatorial
			Console.WriteLine("Digite um valor: ");
			// armazena em uma variavel o valor digitado pelo usuario
			int valor = Convert.ToInt32(Console.ReadLine());
			// imprimi no console o valor do Fatorial
			Console.WriteLine("O Fatorial eh: " + fat1.calcularFatorial(valor));
			// espera o usuario apertar uma tecla para finalizar o programa
			Console.ReadKey();
		}
	}
}
