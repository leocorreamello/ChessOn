using System.Collections;
using System.ComponentModel;

namespace ChessApi.ChessBoard
{
    public class ChessBoard
    {
        public static void Main(string[] args)
        {
            //0 = empty
            //positive numbers = white pieces
            //negative numbers = black pieces
            /*boardMatrix[[-1], [-1], [-1], [-1],  [-1], [-1], [-1], [-1],
                          [-1], [-1], [-1], [-1],  [-1], [-1], [-1], [-1],
                          [0],  [0],  [0],  [0],   [0],  [0],  [0],  [0],
                          [0],  [0],  [0],  [0],   [0],  [0],  [0],  [0],
                          [0],  [0],  [0],  [0],   [0],  [0],  [0],  [0],
                          [0],  [0],  [0],  [0],   [0],  [0],  [0],  [0],
                          [1],  [1],  [1],  [1],   [1],  [1],  [1],  [1],
                          [1],  [1],  [1],  [1],   [1],  [1],  [1],  [1]];*/
            // 0-63, where 0 is a1, 1 is b1, ..., 7 is h1, 8 is a2, ..., 63 is h8

            int[,] boardMatrix = new int[8, 8];

            for (int j = 0; j < 8; j++)
            {
                //define as cores das peças no tabuleiro.
                boardMatrix[0, j] = -1; // black pieces
                boardMatrix[1, j] = -1; // black pawns
                boardMatrix[6, j] = 1; // white pawns
                boardMatrix[7, j] = 1; // white pieces
            }

            //mapeia as posições do tabuleiro para um dicionário, onde a chave é a posição
            //(ex: "a1", "b2") e o valor é o índice correspondente na lista linear.
            List<int> caseBoard = new List<int>();
            Dictionary<string, int> boardLookUp = new Dictionary<string, int>();

            char[] columns = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    //mapeia todas as posições do tabuleiro para uma lista linear
                    int pieceValue = boardMatrix[i, j];
                    caseBoard.Add(pieceValue);

                    //traduz as coordenadas do tabuleiro para um formato mais legível
                    string position = $"{columns[j]}{8 - i}";
                    boardLookUp[position] = pieceValue;
                }
            }

            //TODO: Agora estanciar as peças no jogo com base na matriz do tabuleiro e na lista linear.
        }
    }
}
