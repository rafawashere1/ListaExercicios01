namespace ListaExercicios01.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Conversor de Celsius para Fahrenheit --------");
            Console.WriteLine();
            Console.Write(">> Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine();
            Console.WriteLine($">> A temperatura em Fahrenheit é: {fahrenheit}");
        }
    }
}