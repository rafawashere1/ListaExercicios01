namespace ListaExercicios01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Conversor de Fahrenheit para Celsius --------");
            Console.WriteLine();
            Console.Write("Digite a temperatura em Fahrenheit: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"A temperatura em Celsius é: {celsius}");
        }
    }
}