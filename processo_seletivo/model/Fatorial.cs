namespace processo_seletivo.model
{
	class Fatorial
	{
		// metodo que calcula o Fatorial de forma recursiva
		public int calcularFatorial(int v)
		{
			// Verifica se o valor nao e negativo e se ele e menor ou igual a 2000
			if (v <= 1 && v >= 0 && v <= 2000)
			{
				return 1;
			}
			// a funcao chama a si mesma para diminuir o projeto em N * N - 1 ate o caso base.
			else
			{
				return (v * calcularFatorial(v - 1));
			}
		}
	}
}
