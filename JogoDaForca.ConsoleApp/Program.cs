namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        JogoDaForca jogo = new JogoDaForca();

        while (true)
        {
            jogo.EscolherPalavraSecreta();
            jogo.PreencherLetrasEncontradas();

            while (true)
            {
                jogo.ExibirForca();

                char chute = jogo.ObterChute();

                if (jogo.JogadorAcertou(chute) || jogo.JogadorPerdeu())
                    break;
            }

            Console.Write("Deseja sair do programa? s/N: ");
            string opcaoSair = Console.ReadLine().ToUpper();

            if (opcaoSair == "S") break;

            Console.ReadLine();
        }
    }
}
