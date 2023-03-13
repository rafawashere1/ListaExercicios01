namespace ListaExercicios01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Volume de Cilindro --------");
            Console.WriteLine();
            Console.Write(">> Digite o raio do cilindro: ");
            int raio = Convert.ToInt32(Console.ReadLine());
            Console.Write(">> Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine();
            Console.WriteLine($">> O volume do seu cilindro é: {volume}");
        }
    }
}