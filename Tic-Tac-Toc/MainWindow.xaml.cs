using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int YELLOW_CODE = 0;
        private const int RED_CODE = 1;
        private const int NOT_PLAYED = 2;
        private const int NO_WINNER = -1;
        private int winner = NO_WINNER;
        private int[] gameState = {NOT_PLAYED, NOT_PLAYED, NOT_PLAYED,
            NOT_PLAYED, NOT_PLAYED, NOT_PLAYED,
            NOT_PLAYED, NOT_PLAYED, NOT_PLAYED};
        private int activePlayer = RED_CODE;
        private int[,] winnigPositions = {{0,1,2}, {3,4,5}, {6,7,8},
                                          {0,3,6}, {1,4,7}, {2,5,8},
                                          {0,4,8}, {2,4,6}};

        Node Root = new Node(1, 0);
        Play play = new Play();
        int row, col;


        public MainWindow()
        {
            InitializeComponent();
            MinMaxTree minMaxTree = new MinMaxTree();
        }

        public int checkWinner()
        {
            //foreach (int[] positions in winnigPositions)
                //if (gameState[positions[0]] == gameState[positions[1]] && gameState[positions[1]] == gameState[positions[2]] && gameState[positions[0]] != NOT_PLAYED)
                    //return gameState[positions[0]];
            return NO_WINNER;
        }

        private void test()
        {
            play.play(out row, out col);
            int max = Root.Board[row, col] = (byte)Root.Type;
            switch(max)
            {
                case 1: btn1.Content = "O"; break;
                case 2: btn2.Content = "O"; break;
                case 3: btn3.Content = "O"; break;
                case 4: btn4.Content = "O"; break;
                case 5: btn5.Content = "O"; break;
                case 6: btn6.Content = "O"; break;
                case 7: btn7.Content = "O"; break;
                case 8: btn8.Content = "O"; break;
                case 9: btn9.Content = "O"; break;
            }
        }

        #region Btn
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[0, 0] == 0)
            {
                btn1.Content = "X";
                Root.Board[0, 0] = 2;
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[0, 1] == 0)
            {
                btn2.Content = "X";
                Root.Board[0, 1] = 2;
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[0, 2] == 0)
            {
                btn3.Content = "X";
                Root.Board[0, 2] = 2;
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[1, 0] == 0)
            {
                btn4.Content = "X";
                Root.Board[1, 0] = 2;
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[1, 1] == 0)
            {
                btn5.Content = "X";
                Root.Board[1, 1] = 2;
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[1, 2] == 0)
            {
                btn6.Content = "X";
                Root.Board[1, 2] = 2;
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[2, 0] == 0)
            {
                btn7.Content = "X";
                Root.Board[2, 0] = 2;
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[2, 1] == 0)
            {
                btn8.Content = "X";
                Root.Board[2, 1] = 2;
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Root.Board[2, 2] == 0)
            {
                btn9.Content = "X";
                Root.Board[2, 2] = 2;
            }
        }
        #endregion
    }
}
