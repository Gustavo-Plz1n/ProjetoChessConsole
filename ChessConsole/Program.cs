using ChessConsole.tabuleiro;
using ChessConsole.xadrez;
using System;
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
                    
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino  = Tela.lerPosicaoXadrez().toPosicao();
                    partida.ExecutaMovimento(origem, destino);


                }    
                Tela.imprimirTabuleiro(partida.tab);
                
                Console.ReadLine();
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}