namespace ListaExercicios01.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Dias de Vida --------");
            Console.WriteLine();

            Console.Write(">> Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write(">> Digite quantos anos você tem: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasVividos = idade * 365;

            Console.WriteLine();
            Console.WriteLine($"{nome}, você já viveu {diasVividos} dias.");
        }
    }
}