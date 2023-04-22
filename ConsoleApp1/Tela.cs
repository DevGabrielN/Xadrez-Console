using TabuleiroConsole;
namespace Xadrez_Console;

internal class Tela
{
    public static void ImprimirTabuleiro(Tabuleiro tab)
    {
        for(int i = 0;  i < tab.Linhas; i++) { 
            for(int j = 0; j < tab.Colunas; j++)
            {
                if (tab.Pecas(i, j) != null) { 
                    Console.Write(tab.Pecas(i,j)+ " ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
    }
}
