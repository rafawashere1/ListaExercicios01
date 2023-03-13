namespace ListaExercicios01.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de salário --------");
            Console.WriteLine();

            Console.Write(">> Digite o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = salario * 0.15;
            double salarioAumentado = aumento + salario;
            double imposto = salarioAumentado * 0.08;
            double salarioImposto = salarioAumentado - imposto;

            Console.WriteLine();
            Console.WriteLine($">> O salário do funcionário é {salario}. Com o aumento de 15%, o salário é {salarioAumentado} e após o imposto de 8%, o salário é {salarioImposto}");
        }
    }
}