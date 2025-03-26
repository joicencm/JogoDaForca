

internal class Program
{
    //Versão 4: Exibir boneco da forca
    static void Main(string[] args)
    {
        while (true)
        {

            string palavraSecreta = "UVA";

            char[] letrasEncontradas = new char[palavraSecreta.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
            {
                //acessar a array no indice 0
                letrasEncontradas[caractere] = '_';
            }

            int quantidadeErros = 0;
            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;

            do
            {

                string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
                string tronco = quantidadeErros >= 2 ? "x" : " ";
                string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
                string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
                string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
                string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

                string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
                Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
                Console.WriteLine(" |        {0}       ", troncoBaixo);
                Console.WriteLine(" |        {0}       ", pernas);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");
                Console.WriteLine("----------------------------------------------");

                Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Quantidade de Erros: " + quantidadeErros);
                Console.WriteLine("------------------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // otém apenas um caractere do que o usuário digita

                bool letraFoiEncontrada = false;

                for (int contador = 0; contador < palavraSecreta.Length; contador++)
                {
                    char letraAtual = palavraSecreta[contador];

                    if (chute == letraAtual)
                    {
                        letrasEncontradas[contador] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                dicaDaPalavra = string.Join("", letrasEncontradas);

                jogadorAcertou = dicaDaPalavra == palavraSecreta;

                jogadorEnforcou = quantidadeErros > 5;

                if (jogadorAcertou)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Você acertou a palavra secreta! Era: " + palavraSecreta);
                    Console.WriteLine("------------------------------------------------");
                }
                else if (jogadorEnforcou)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Que azer, tente novamente! A palavra era: " + palavraSecreta);
                    Console.WriteLine("------------------------------------------------");
                }

            } while (jogadorAcertou == false && jogadorEnforcou == false);
            Console.ReadLine();
        }
}
    }
