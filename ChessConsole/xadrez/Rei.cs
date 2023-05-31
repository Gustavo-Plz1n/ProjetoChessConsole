using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
namespace ChessConsole.xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }
        public override string ToString()
        {
            return "R";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.quantMovimentos == 0;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            //Acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Ne
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //se
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //so
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //no
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // #jogadaEspecial Roque
            if (quantMovimentos == 0 && !partida.Xeque)
            {
                //Roque Pequeno
                Posicao PosT1 = new Posicao(posicao.Linha, posicao.Coluna + 3);
                if (TesteTorreParaRoque(PosT1))
                {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna + 2);
                    if (tab.peca(p1) == null && tab.peca(p2) == null)
                    {
                        mat[posicao.Linha, posicao.Coluna + 2] = true;
                    }
                }
            }
            if (quantMovimentos == 0 && !partida.Xeque)
            {
                //Roque Grande
                Posicao PosT2 = new Posicao(posicao.Linha, posicao.Coluna - 4);
                if (TesteTorreParaRoque(PosT2))
                {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna - 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna - 2);
                    Posicao p3 = new Posicao(posicao.Linha, posicao.Coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[posicao.Linha, posicao.Coluna - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}
