using TabuleiroConsole;
using Xadrez_Console;
using Xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            PartidaDeXadrez partidaDeXadre = new PartidaDeXadrez();
            while (!partidaDeXadre.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partidaDeXadre.Tab);
                Console.Write("\nOrigem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                bool[,] posicoesPossiveis = partidaDeXadre.Tab.Pecas(origem).MovimentosPosiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partidaDeXadre.Tab, posicoesPossiveis);

                Console.Write("\nDestino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                partidaDeXadre.ExecutaMovimento(origem, destino);   
            }
        }
        catch (TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}