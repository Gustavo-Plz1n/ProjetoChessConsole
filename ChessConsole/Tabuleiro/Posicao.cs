using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
     class Posicao
    {
        public int Linha{get; set; }
        public int Coluna{get; set; }
        public Posicao (int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }




    }
}
