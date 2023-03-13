namespace ListaExercicios01.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Sequência de Fibonacci --------");
            Console.WriteLine();

            Console.Write(">> Digite o número em que quer parar a sequência: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            decimal valor1 = 0;
            decimal valor2 = 1;
            decimal valor3 = 0;

            Console.WriteLine("0");
            Console.WriteLine("1");
            for (int i = 0; i < numero; i++)
            {
                valor3 = valor1 + valor2;
                Console.WriteLine(valor3);
                valor1 = valor2;
                valor2 = valor3;
            }


        }
    }
}