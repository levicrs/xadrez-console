using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            PartidaXadrez partida = new();

            while (!partida.terminada) {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.ExecutaMovimento(origem, destino);

            }


        }
    }
}
