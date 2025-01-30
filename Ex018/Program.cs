namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Calcular a Àrea do Triângulo");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.WriteLine("Digite a base do triângulo(m): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triângulo(m): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

    
            area(a, b);
        }

        static void area(double bas, double altura)
        {
            double a = (bas * altura) / 2;
            Console.WriteLine($"A área do triângulo de {bas} * {altura}/ 2 é de {a:F2}m²");
            Console.WriteLine();
        }
    }
}
