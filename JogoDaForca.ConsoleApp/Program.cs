namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 1: Estrutura básica e entrada do usuário
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-------------------------------------");

                Console.Write("Digite uma letra: "); 
                char chute = Console.ReadLine()[0]; // obtém apenas um caractere do que o usuário digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }
    }
}
