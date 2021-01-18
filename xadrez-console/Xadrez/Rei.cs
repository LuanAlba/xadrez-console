using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            //apenas instanciando a posição
            Posicao pos = new Posicao(0, 0);

            // se possivel movimentar acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos)&& podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna +1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar direita
            pos.definirValores(posicao.linha , posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar sudeste
            pos.definirValores(posicao.linha +1, posicao.coluna + 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar sul
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar sudoeste
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar oeste
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // se possivel movimentar noroeste
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
