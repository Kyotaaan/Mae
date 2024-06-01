using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private TicTacToe game;
        private Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
            game = new TicTacToe(this);
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            buttons = new Button[3, 3] { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int rowIndex = int.Parse(button.Tag.ToString()) / 3;
            int colIndex = int.Parse(button.Tag.ToString()) % 3;
            game.MakeMove(rowIndex, colIndex, button);
        }

        public void UpdateScore(string winner)
        {
            if (winner == "X")
                px_score.Text = (int.Parse(px_score.Text) + 1).ToString();
            else
                po_score.Text = (int.Parse(po_score.Text) + 1).ToString();
        }

        public void UpdateStatus(string status)
        {
            lbl3.Text = status;
        }

        public void ResetBoard()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            lbl3.Text = "";
        }

        public void DisableAllButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            game.Reset();
        }

        private void NG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        public abstract class Game
        {
            protected string[,] Board;
            protected bool isPlayerX;

            public Game()
            {
                Board = new string[3, 3];
                isPlayerX = true;
            }

            protected abstract string CheckWinner();

            public abstract void Reset();
        }

        public class TicTacToe : Game
        {
            private Form1 form;

            public TicTacToe(Form1 form)
            {
                this.form = form;
            }

            protected override string CheckWinner()
            {
                string winner = null;

                for (int i = 0; i < 3; i++)
                {
                    if (Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2] && Board[i, 0] != null)
                    {
                        winner = Board[i, 0];
                        break;
                    }

                    if (Board[0, i] == Board[1, i] && Board[1, i] == Board[2, i] && Board[0, i] != null)
                    {
                        winner = Board[0, i];
                        break;
                    }
                }

                if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && Board[0, 0] != null)
                    winner = Board[0, 0];
                else if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && Board[0, 2] != null)
                    winner = Board[0, 2];

                if (winner != null)
                {
                    form.UpdateScore(winner);
                    form.DisableAllButtons();
                    return $"Player {winner} Wins!";
                }

                return "";
            }

            public override void Reset()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Board[i, j] = null;
                    }
                }

                isPlayerX = true;
                form.ResetBoard();
            }

            public void MakeMove(int row, int col, Button button)
            {
                if (isPlayerX)
                {
                    button.Text = "X";
                    Board[row, col] = "X";
                }
                else
                {
                    button.Text = "O";
                    Board[row, col] = "O";
                }

                button.Enabled = false;
                isPlayerX = !isPlayerX;

                string result = CheckWinner();
                if (result != "")
                    form.UpdateStatus(result);
            }
        }
    }
}
