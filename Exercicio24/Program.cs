namespace ListaExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Soma de Números Ímpares Múltiplos de 3 --------");
            Console.WriteLine();

            double soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}