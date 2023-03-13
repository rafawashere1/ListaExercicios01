namespace ListaExercicios01.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Padaria Hotpão --------");
            Console.WriteLine();

            Console.Write(">> Digite a quantidade de pães vendidos: ");
            double paes = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite a quantidade de broas vendidas: ");
            double broas = Convert.ToDouble(Console.ReadLine());

            double precopao = 0.12;
            double precobroa = 1.50;
            double arrecadadoPao = paes * precopao;
            double arrecadadoBroa = broas * precobroa;
            double totalArrecadado = arrecadadoPao + arrecadadoBroa;
            double poupanca = totalArrecadado * 0.10;

            Console.WriteLine();
            Console.WriteLine($"O total arrecadado foi: {totalArrecadado} e deve guardar {Math.Round(poupanca, 2)} na poupança.");
        }
    }
}