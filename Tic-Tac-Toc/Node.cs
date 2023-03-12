using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toc
{
    class Node
    {
        private const int NOT_PLAYED = 2;
        private const int n = 3;
        public byte[,] Board = new byte[n, n];
        public List<Node> NextMoves = new List<Node>();
        public int Type;
        public int Point;
        private int[] gameState = {NOT_PLAYED, NOT_PLAYED, NOT_PLAYED,
            NOT_PLAYED, NOT_PLAYED, NOT_PLAYED,
            NOT_PLAYED, NOT_PLAYED, NOT_PLAYED};


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">2 min ,1 max</param>
        /// <param name="point"></param>
        public Node(int type, int point)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Board[i, j] = 0;
            Type = type;
            Point = point;
            int row = -1, col = -1;
            switch (Point)
            {
                case 1: row = col = 0; break;
                case 2: row = 0; col = 1; break;
                case 3: row = 0; col = 2; break;
                case 4: row = 1; col = 0; break;
                case 5: row = col = 1; break;
                case 6: row = 1; col = 2; break;
                case 7: row = 2; col = 0; break;
                case 8: row = 2; col = 1; break;
                case 9: row = col = 2; break;
            }
            if (row != -1 && col != -1)
                Board[row, col] = (byte)Type;
        }
    }
}
