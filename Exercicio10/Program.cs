namespace ListaExercicios01.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculadora de Média Ponderada -------- ");
            Console.WriteLine();

            Console.Write(">> Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o peso da primeita nota: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o peso da segunda nota: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o peso da terceira nota: ");
            double peso3 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine();
            Console.WriteLine($">> A média ponderada é: {mediaPonderada}");
        }
    }
}