namespace ListaExercicios01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Área --------");
            Console.WriteLine();

            Console.Write(">> Digite a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine();
            Console.WriteLine($">> A área do seu terreno é: {area}");
        }
    }
}