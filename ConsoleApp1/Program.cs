namespace ListaExercicios01.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Média Harmônica --------");
            Console.WriteLine();

            Console.Write(">> Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double mediaHarmonica = 3 / (1 / nota1 + 1 / nota2 + 1 / nota3);

            Console.WriteLine();
            Console.WriteLine($">> A Média Harmônica das notas do aluno é: {mediaHarmonica}");
        }
    }
}