namespace ListaExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de volume de caixa retangular -------- ");
            Console.WriteLine();
            Console.Write("Digite o primero lado da caixa: ");
            int ladoA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo lado da caixa: ");
            int ladoB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro lado da caixa: ");
            int ladoC = Convert.ToInt32(Console.ReadLine());

            int volume = ladoA * ladoB * ladoC / 1000;

            Console.WriteLine($"O volume da caixa retangular é: {volume}");

        }
    }
}