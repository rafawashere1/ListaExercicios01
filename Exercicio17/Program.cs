namespace ListaExercicios01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Impressão de Valores --------");
            Console.WriteLine();

            Console.Write(">> Digite o valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o valor C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.WriteLine(">> A soma dos valores A e B é menor do que o valor C");
            }
            else
            {
                Console.WriteLine(">> A soma dos valores A e B é maior do que o valor C");
            }
        }
    }
}