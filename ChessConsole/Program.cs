using ChessConsole.tabuleiro;
using ChessConsole.xadrez;
using System;
using System.Diagnostics;
using tabuleiro;

namespace ChessConsole // Note: actual namespace depends on the project name.

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada)
                {
                    Console.Clear();

                    Tela.ImprimirTabuleiro(partida.tab);


                    
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.ExecutaMovimento(origem, destino);


                }
                

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}