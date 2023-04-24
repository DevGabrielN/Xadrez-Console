namespace TabuleiroConsole
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Peca { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Peca = new Peca[linhas, colunas];
        }
        public Peca Pecas(int linha, int coluna)
        {
            return Peca[linha, coluna];
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            Peca[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
