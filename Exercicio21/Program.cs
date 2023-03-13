namespace ListaExercicios01.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Somar ou Multiplicar? --------");
            Console.WriteLine();

            Console.Write(">> Digite o primeiro número: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o segundo número: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            if (valorA == valorB)
            {
                double c = valorA + valorB;
                Console.WriteLine();
                Console.WriteLine($">> {valorA} + {valorB} é igual a {c}");
            }
            
            else
            {
                double c = valorA * valorB;
                Console.WriteLine();
                Console.WriteLine($">> {valorA} x {valorB} é igual a {c}");
            }
        }
    }
}