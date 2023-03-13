namespace ListaExercicios01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Verificador de Número Primo -------- ");
            Console.WriteLine();

            Console.Write(">> Digite o número que quer verificar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write(">> Digite o Número do Divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if (numero % divisor == 0) 
            {
                Console.WriteLine();
                Console.WriteLine(">> Número é primo");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(">> Número não é primo");
            }
        }
    }
}
