

    internal class Program
    {
    //Versão 1 Estrutura Basica do Projeto
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("------------------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // otém apenas um caractere do que o usuário digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }
    }
