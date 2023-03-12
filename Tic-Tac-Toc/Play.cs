using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toc
{
    class Play
    {
        MinMaxTree minMaxTree = new MinMaxTree();

        public int play(out int row, out int col)
        {
            row = col = -1;
            string content = string.Empty;
            Node Max = minMaxTree.getMax();
            switch (Max.Point)
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
            return Max.Point;
        }

        public int Win(byte[,] Board)
        {
            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2]) return 1;
            if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2]) return 1;
            if (Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0]) return 1;
            if (Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2]) return 1;
            if (Board[2, 0] == Board[1, 1] && Board[1, 1] == Board[0, 2]) return 1;
            if (Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2]) return 1;
            if (Board[0, 0] == 0 && Board[0, 1] == 0 && Board[0, 2] == 0 && 
                Board[1, 0] == 0 && Board[1, 1] == 0 && Board[1, 2] == 0 && 
                Board[2, 0] == 0 && Board[2, 1] == 0 && Board[2, 2] == 0) return 0;
            return -1;
        }
    }
}
