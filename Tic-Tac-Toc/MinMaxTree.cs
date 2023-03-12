using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toc
{
    class MinMaxTree
    {
        public Node Root = new Node(1, 0);

        public MinMaxTree()
        {
            for (int i = 1; i <= 9; i++)
                Root.NextMoves.Add(new Node(2, i));
            for (int i = 2; i <= 9; i++)
            {
                Root.NextMoves[0].NextMoves.Add(new Node(1, i));
                Root.NextMoves[0].NextMoves[0].Board[0, 0] = 2;
            }
        }

        public Node getMax()
        {
            int max = 3;
            return (Node)Root.NextMoves.Where(k => k.Point == max);
        }
    }
}
