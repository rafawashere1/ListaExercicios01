namespace ListaExercicios01.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Lista de Ímpares --------");
            Console.WriteLine();

            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($">> {i} é um número ímpar.");
                }
            }
        }
    }
}