namespace ListaExercicios01.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Fatorial --------");
            Console.WriteLine();

            Console.Write(">> Digite um número: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double fatorial = 1;
            for (double i = a; i >= 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine();
            Console.WriteLine($">> {a}! = {fatorial}");
        }
    }
}