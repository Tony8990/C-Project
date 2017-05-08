using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MossadelCavaliere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bordersize;
        int Triedmove;
        private void buttonstart_Click(object sender, EventArgs e)
        {
            try
            {
                bordersize = int.Parse(textsize.Text);
            }
            catch
            {
                bordersize = 8;
                textsize.Text = bordersize.ToString();
            }
            int[,] board = new int[bordersize, bordersize];
            //posizione cavallo
            Position InitialPosition;
            InitialPosition.row =0;
            InitialPosition.col = 0;

            int doneMoves = 0;

            Position CurrentPoisition = InitialPosition;

            MarckMove(board, CurrentPoisition, ref doneMoves);

            MoveHorse(board, CurrentPoisition, doneMoves);
            

        }

        private void MoveHorse(int[,] board, Position currentPoisition, int doneMoves)
        {
            
        }

        private void MarckMove(int[,] board, Position currentPoisition, ref int doneMoves)
        {
            doneMoves++;
            board[currentPoisition.row, currentPoisition.col] = doneMoves;
        }
        private void unMarckMove(int[,] board, Position currentPoisition, ref int doneMoves)
        {

            board[currentPoisition.row, currentPoisition.col] = 0;
            doneMoves--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    struct Position
    {
        public int row;
        public int col;
    }

}
