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
                Console.Write("Destino: ");
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