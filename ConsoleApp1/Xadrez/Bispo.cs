using TabuleiroConsole;

namespace Xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "B";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Pecas(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPosiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Noroeste
            pos.DefinirPosicao(Posicao.Linha - 1, Posicao.Coluna -1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.DefinirPosicao(pos.Linha - 1, pos.Coluna -1);
            }

            //Nordeste
            pos.DefinirPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.DefinirPosicao(pos.Linha - 1, pos.Coluna + 1);
            }

            //Sudeste
            pos.DefinirPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.DefinirPosicao(pos.Linha + 1, pos.Coluna + 1);
            }
            //Sudoeste
            pos.DefinirPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.DefinirPosicao(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;
        }
    }
}
