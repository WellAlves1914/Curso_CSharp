namespace Vetor_Frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Graviola", "Abacate", "Abacaxi", "Banana", "Caju", "Kiwi", "Caqui", "Limão", "Morango", "Melancia" };
            int[] precos = { 18, 12, 13, 11, 15, 20, 16, 5, 8, 30 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + frutas[i] + " é de R$ " + precos[i]);
            }
            Console.WriteLine();
            string frutas_ultimas = frutas.Max();
            string frutas_primeiras = frutas.Min();
            Console.WriteLine("A primeira fruta é " + frutas_primeiras);
            Console.WriteLine("A última fruta é " + frutas_ultimas);
            int frutas_altas = precos.Max();
            int frutas_baixas = precos.Min();
            Console.WriteLine("A fruta mais cara custa R$ " + frutas_altas);
            Console.WriteLine("A fruta mais barata custa R$ " + frutas_baixas);
        }
    }
}
