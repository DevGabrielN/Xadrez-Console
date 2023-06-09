﻿using TabuleiroConsole;
using Xadrez_Console;
using Xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            PartidaDeXadrez partidaDeXadre = new PartidaDeXadrez();
            while (!partidaDeXadre.Terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.ImprimirPartida(partidaDeXadre);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    partidaDeXadre.ValidarPosicaoDeOrigem(origem);
                    bool[,] posicoesPossiveis = partidaDeXadre.Tab.Pecas(origem).MovimentosPosiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadre.Tab, posicoesPossiveis);

                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partidaDeXadre.ValidarPosicaoDeDestino(origem, destino);
                    partidaDeXadre.ExecutaJogada(origem, destino);
                }
                catch (TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.ImprimirPartida(partidaDeXadre);
        }
        catch (TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}