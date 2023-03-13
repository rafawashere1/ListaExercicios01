namespace ListaExercicios01.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Volume de Esfera --------");
            Console.WriteLine();
            Console.Write(">> Digite o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = 4.0 * Math.PI * Math.Pow(raio, 3) / 3.0;

            Console.WriteLine();
            Console.WriteLine($">> O volume da sua esfera é: {volume}");
        }
    }
}