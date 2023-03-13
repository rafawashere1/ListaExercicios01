namespace ListaExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Tabuada --------");
            Console.WriteLine();

            Console.Write(">> Digite um valor de 1 a 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 10)
            {
                Console.WriteLine();
                Console.WriteLine(">> Valor inválido.");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    double tabuada = i * n;
                    Console.WriteLine();
                    Console.WriteLine($">> {i} x {n} = {tabuada}");
                }
            }
        }
    }
}