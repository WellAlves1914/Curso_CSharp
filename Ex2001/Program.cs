namespace Ex2001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aumento;
            double salario;

            Console.WriteLine("Digite o seu salário");
            aumento = Convert.ToDouble(Console.ReadLine());


            if (aumento > 2500)
            {
                salario = aumento * 0.05;
                Console.WriteLine("Você reberá um salário somado de R$ {0} + {1}, no final fica R${2}", aumento, salario, aumento + salario);
            }
            else if (aumento > 1250)
            {
                salario = aumento * 0.10;
                Console.WriteLine("Você reberá um salário somado de R$ {0} + {1}, no final fica R${2}", aumento, salario, aumento + salario);
            }
            else
            {
                salario = aumento * 0.15;
                Console.WriteLine("Você reberá um salário somado de R$ {0} + {1}, no final fica R${2}", aumento, salario, aumento + salario);

            }
        }
    }
}
