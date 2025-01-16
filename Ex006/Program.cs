namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int resposta, num3;

            Console.WriteLine("Digite uma nota");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outra nota");
            num2 = Convert.ToInt32(Console.ReadLine());
            num3= num1 + num2;
            resposta = num3 / 2;
            Console.WriteLine("a média de {0}", resposta);


        }   
    }
}
