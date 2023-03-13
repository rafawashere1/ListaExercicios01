namespace ListaExercicios01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculadora IMC --------");
            Console.WriteLine();

            Console.Write(">> Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine();
                Console.WriteLine(">> Abaixo do peso.");
            }
            
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine();
                Console.WriteLine(">> Peso normal.");
            }

            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine();
                Console.WriteLine(">> Acima do peso.");
            }

            else if (imc >= 30)
            {
                Console.WriteLine();
                Console.WriteLine(">> Obeso.");
            }
        }
    }
}