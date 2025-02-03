namespace Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc;
            Console.Write("Digite o ano de nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(voto(nasc));
        }

        static string voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            // int dia = dataAtual.Day;
            // int mes = dataAtual.Month;
            int anoAtual = dataAtual.Year;
            // int hora = dataAtual.Hour;
            // int minuto = dataAtual.Minute;
            // int segundo = dataAtual.Second;
            int idade = anoAtual - ano;

            if (idade < 16)
            {
                return $"Com {idade} anos, você não vota. ";
            } 
            else if(idade > 18 && idade < 70)
            {
                return $"Com {idade} anos, você vota. ";
            }
            else
            {
                return $"Com {idade} anos, seu voto é opcional. ";
            }
        }
    }
}
