

internal class Program
{
    //Versão 2: Exibir palavra oculta com traços
    static void Main(string[] args)
    {
        while (true)
        {

            string palavraSecreta = "MELANCIA";

            char[] letrasEncontradas = new char[palavraSecreta.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                //acessar a array no indice 0
                letrasEncontradas[caractere] = '_';
            }

            string dicaDaPalavra = string.Join(" ",letrasEncontradas);

            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
            Console.WriteLine("------------------------------------------------");

            Console.Write("Digite uma letra: ");
            char chute = Console.ReadLine()[0]; // otém apenas um caractere do que o usuário digita

            Console.WriteLine(chute);

            Console.ReadLine();
        }
    }
}
