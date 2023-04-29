using TabuleiroConsole;
using Xadrez_Console;
using Xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('a', 1);
        Console.WriteLine(pos.ToPosicao());

    }
}