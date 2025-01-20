namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidade;
            string resultado;
            Console.WriteLine("Qual a velocidade do carro");
            velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade > 80)
            {
                velocidade = (velocidade - 80) * 7;
                Console.WriteLine("Você foi multado + Você foi multado em R$ {0}", velocidade);
            }

            else
            {
                Console.WriteLine ("Velocidade normal");
            }
          
        }

    }
}

