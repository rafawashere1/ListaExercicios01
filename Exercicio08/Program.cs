namespace ListaExercicios01.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Volume de Lata de Óleo --------");
            Console.WriteLine();
            Console.Write(">> Digite o raio da lata: ");
            int raio = Convert.ToInt32(Console.ReadLine());
            Console.Write(">> Digite a altura da lata: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = 3.14 * raio * raio * altura;

            Console.WriteLine();
            Console.WriteLine($">> O volume da sua lata de óleo é: {volume}");
        }
    }
}