namespace ListaExercicios01.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Tabuada em Colunas --------");
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($">> {i} x {0} = {i * 0}");
                Console.WriteLine($">> {i} x {1} = {i * 1}");
                Console.WriteLine($">> {i} x {2} = {i * 2}");
                Console.WriteLine($">> {i} x {3} = {i * 3}");
                Console.WriteLine($">> {i} x {4} = {i * 4}");
                Console.WriteLine($">> {i} x {5} = {i * 5}");
                Console.WriteLine($">> {i} x {6} = {i * 6}");
                Console.WriteLine($">> {i} x {7} = {i * 7}");
                Console.WriteLine($">> {i} x {8} = {i * 8}");
                Console.WriteLine($">> {i} x {9} = {i * 9}");
                Console.WriteLine($">> {i} x {10} = {i * 10}");
                Console.WriteLine();
            }
        }
    }
}