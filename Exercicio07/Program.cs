namespace ListaExercicios01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculador de Salário --------");
            Console.WriteLine();

            Console.Write(">> Digite o salário base do funcionário: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o valor total das vendas: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write(">> Digite o percentual de comissão: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double comissaoBruta = percentual / 100;
            double comissaoReal = vendas * comissaoBruta;
            double salario = salarioBase + comissaoReal;

            Console.WriteLine();
            Console.WriteLine($">> O salário do funcionário é: {salario}");
        }
    }
}