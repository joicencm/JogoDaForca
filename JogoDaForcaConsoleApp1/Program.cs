internal class Program
{
    //Versão 5: Escolher uma palavra aleatória
    static void Main(string[] args)
    {
        while (true)
        {
            string[] fruta = { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

            string[] animal = { "CACHORRO", "GATO", "COELHO", "PASSARO", "PEIXE", "LEAO", "TIGRE", "ELEFANTE", "ONCA", "URSO", "RAPOSA", "JAVALI", "RENDA", "MACACO", "ZEBRA", "GIRAFA", "AVESTRUZ", "CAIMÃO", "CAMELO", "ALIGATOR", "CAVALO", "ESQUILO", "PANDA", "GORILA", "QUEIXADA", "VELHO", "CAVALINHO", "BOI", "OVELHA", "PODEIRO", "ISPA" };

            String[] paises = { "BRASIL", "ARGENTINA", "EUA", "CANADA", "MEXICO", "INGLATERRA", "FRANCA", "ESPANHA", "ITALIA", "ALEMANHA", "RÚSSIA", "AUSTRALIA", "CHINA", "JAPAO", "INDIA", "AFRICA DO SUL", "EGITO", "ARABIA SAUDITA", "PAQUISTAO", "BANGLADESH", "ARGELIA", "INDONESIA", "TAILANDIA", "COLOMBIA", "VENEZUELA", "PERU", "CHILE", "PORTUGAL", "SUECIA", "NORUEGA", "FINLANDIA" };

            // Menu de categorias
            Console.WriteLine("1. Frutas");
            Console.WriteLine("2. Animais");
            Console.WriteLine("3. Países");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Escolha uma categoria: ");

            int categoriaEscolhida = Convert.ToInt32(Console.ReadLine());

            string[] categoriaSelecionada = categoriaEscolhida switch
            {
                1 => fruta,
                2 => animal,
                3 => paises,
                _ => throw new ArgumentException("Categoria inválida.")
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(categoriaSelecionada.Length);

            string palavraSecreta = categoriaSelecionada[indiceEscolhido];

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
        }
    }
}
