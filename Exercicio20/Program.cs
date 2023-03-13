namespace ListaExercicios01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Verificador de Par ou Ímpar --------");
            Console.WriteLine();

            Console.Write(">> Informe o número que quer verificar: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0 )
            {
                Console.WriteLine();
                Console.WriteLine(">> Número par.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(">> Número Ímpar.");
            }
        }
    }
}