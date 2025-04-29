namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            JogoDaForca jogo = new JogoDaForca();

            while (true)
            {
                jogo.ExibirCabecalho();

                char chute = jogo.ObterChute();

                if (jogo.JogadorAcertou(chute) || jogo.JogadorPerdeu())
                {
                    Console.WriteLine(jogo.mensagemFinal);
                    break;
                }
            }

            Console.Write("Deseja sair do programa? s/N: ");
            string opcaoSair = Console.ReadLine().ToUpper();

            if (opcaoSair == "S") break;

            Console.ReadLine();
        }
    }
}
