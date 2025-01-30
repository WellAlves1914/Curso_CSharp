using System.ComponentModel.Design;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o operador (1=+, 2=-, 3=*, 4=/ ");
            string conta = Console.ReadLine();

            if (conta == "+")
            {
                soma(num1, num2);
            }
            else if (conta == "-")
            {
                sub(num1, num2);
            }
            else if (conta == "*")
            {
                multiplicacao(num1, num2);
            }
            else if (conta == "/")
            {
                divisao(num1, num2);
            }


            static void soma(int a, int b)
            {
                int resultado = a + b;
                Console.WriteLine("A soma de " + a + " + " + b + " = " + resultado);
            }


            static void sub(int a, int b)
            {
                int resultado = a - b;
                Console.WriteLine("A subtração de " + a + " - " + b + " = " + resultado);
            }

            static void multiplicacao(int a, int b)
            {
                int resultado = a + b;
                Console.WriteLine("A multiplicação de " + a + " * " + b + " = " + resultado);
            }

            static void divisao(int a, int b)
            {
                int resultado = a + b;
                Console.WriteLine("A divisão de " + a + " / " + b + " = " + resultado);
            }
        }
    }
}