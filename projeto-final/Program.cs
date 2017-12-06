﻿using System;
using tabuleiro;
using Xadrez;

namespace projeto_final
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.branca), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine(); 

        }
    }
}
