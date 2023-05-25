using System;
using tabuleiro;

namespace ChessConsole // Note: actual namespace depends on the project name.
    
{
     class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();



        }
    }
}