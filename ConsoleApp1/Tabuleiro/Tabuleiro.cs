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
        public Peca Pecas(Posicao pos)
        {
            try
            {
                return Peca[pos.Linha, pos.Coluna];
            }
            catch(IndexOutOfRangeException)
            {
                throw new TabuleiroException("Posição inválida! ");
            }
        }
        public Peca Pecas(int linha, int coluna)
        {
            return Peca[linha, coluna];
        }
        public bool ExistePeca(Posicao pos) {
            ValidarPosicao(pos);
            return Pecas(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Peca[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(Pecas(pos) == null)
            {
                return null;
            }
            Peca aux = Pecas(pos);
            aux.Posicao = null;
            Peca[pos.Linha, pos.Coluna] = null;
            return aux;
        }
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >=Linhas || pos.Coluna<0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
