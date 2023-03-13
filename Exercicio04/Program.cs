namespace ListaExercicios01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Calculadora de consumo de combustível --------");
            Console.WriteLine();
            Console.Write(">> Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write(">> Digite a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.Write(">> Digite a gasolina gasta no percurso: ");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            double consumo = (kmInicial -  kmFinal) / gasolina;

            Console.WriteLine();
            Console.WriteLine($">> O seu consumo de combustível foi de: {consumo}");
        }
    }
}