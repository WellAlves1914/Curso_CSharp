namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Wellington Amarante Alves");
            Console.WriteLine();
            escreva("Curso C#");
            Console.WriteLine();
            escreva("Olá");
            Console.WriteLine();
        }

        static void escreva(string texto)
        {
            /* Escreva o texto centralizado em uma linha com o caracter informado*/

            char caracter = '='; // Caracter que será impresso
            int tamanho = texto.Length + 4; // Tamanho da linha
            string linha = new string(caracter, tamanho); // Cria uma linha com o caracter informado
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // Centraliza o texto
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
    }
}
