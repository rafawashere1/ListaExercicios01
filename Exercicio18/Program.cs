namespace ListaExercicios01.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Ordenador Decrescente --------");
            Console.WriteLine();

            Console.WriteLine(">> Digite três números inteiros e diferentes.");
            Console.WriteLine();
            Console.Write(">> Digite o primeiro número inteiro: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(">> Digite o segundo número inteiro: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(">> Digite o terceiro número inteiro: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine();
                Console.WriteLine(">> Operação inválida.");
            }

            if (numero1 < numero2 && numero1 < numero3 && numero2 < numero3)
            {
                Console.WriteLine(numero3);
                Console.WriteLine(numero2);
                Console.WriteLine(numero1);
            }
            else if (numero2 < numero1 && numero2 < numero3 && numero1 < numero3)
            {
                Console.WriteLine(numero3);
                Console.WriteLine(numero1);
                Console.WriteLine(numero2);
            }
            else if (numero3 < numero1 && numero3 < numero2 && numero1 < numero2)
            {
                Console.WriteLine(numero2);
                Console.WriteLine(numero1);
                Console.WriteLine(numero3);
            }
            else if (numero1 < numero2 && numero1 < numero3 && numero3 < numero2)
            {
                Console.WriteLine(numero2);
                Console.WriteLine(numero3);
                Console.WriteLine(numero1);
            }
            else if (numero2 < numero1 && numero2 < numero3 && numero3 < numero1)
            {
                Console.WriteLine(numero1);
                Console.WriteLine(numero3);
                Console.WriteLine(numero2);
            }
            else if (numero3 < numero1 && numero3 < numero2 && numero2 < numero3)
            {
                Console.WriteLine(numero1);
                Console.WriteLine(numero2);
                Console.WriteLine(numero3);
            }
        }
    }
}