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
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos.toPosicao());
            Console.WriteLine(pos);
        }
    }
}