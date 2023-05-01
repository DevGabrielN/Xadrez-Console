namespace TabuleiroConsole
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }

        public void IncrementarQteMovimento()
        {
            QtdMovimentos++;
        }
        public void DecrementarQteMovimento()
        {
            QtdMovimentos--;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPosiveis();

            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPosiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPosiveis();

    }
}
