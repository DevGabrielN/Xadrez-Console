using TabuleiroConsole;
using Xadrez_Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);
        Tela.ImprimirTabuleiro(tab);
    }
}