using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scacchi {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        int BoardSize; //grandezza scacchiera
        int[,] Offset = new int[8, 2]
            {
                {+2,+1}, {+1,+2},
                {-1,+2}, {-2,+1},
                {-2,-1}, {-1,-2},
                {+1,-2}, {+2,-1}
            };

        private void btnStart_Click(object sender, EventArgs e) {
            //controlla se non ci sono eccezioni in input
            try {
                BoardSize = int.Parse(txtSize.Text); //converte l'input
            } catch {
                BoardSize = 8; //default size
                txtSize.Text = BoardSize.ToString(); //stampa default size nell'oggetto
            }
            int[,] Board = new int[BoardSize, BoardSize]; //dichiara una matrice scacchiera
            
            //posizione cavallo
            Position InitialPosition;
            InitialPosition.row = 0;
            InitialPosition.col = 0;

            //mosse fatte
            int DoneMoves = 0,
               TriedMoves = 0;

            //posizione corrente
            Position CurrentPosition = InitialPosition;
            MarkMove(Board, CurrentPosition, ref DoneMoves); //segna sulla matrice il movimento fatto
            MoveHorse(Board, CurrentPosition, DoneMoves); //muove il cavallo 
            ShowBoard(Board);
        }

        //muove il cavallo, ma per sicurezza il contatore delle mosse viene passato by value
        private bool MoveHorse(int[,] Board, Position CurrentPosition, int DoneMoves) {
            if (DoneMoves == BoardSize * BoardSize)
                return true;
            

            for(int i=0;i<8;i++)
            {
                Position NextPosition = CurrentPosition;
                NextPosition.col += Offset[i, 0];
                NextPosition.row += Offset[i, 1];
                if(IsValid(Board, NextPosition))
                {
                    MarkMove(Board, NextPosition, ref DoneMoves);
                    if(MoveHorse(Board, NextPosition, DoneMoves))
                        return true;
                    UnMarkMove(Board, NextPosition, ref DoneMoves);
                }
            }
            return false;
        }

        //segna sulla matrice il movimento fatto
        private void MarkMove(int[,] Board, Position CurrentPosition, ref int DoneMoves) {
            DoneMoves++;
            Board[CurrentPosition.row, CurrentPosition.col] = DoneMoves;
            TriedMoves++;

        }

        //toglie dalla matrice il movimento fatto
        private void UnMarkMove(int[,] Board, Position CurrentPosition, ref int DoneMoves) {
            Board[CurrentPosition.row, CurrentPosition.col] = 0;
            DoneMoves--;
        }

        private void ShowBoard(int[,] Board)
        {
            for(int r=0;r<BoardSize;r++)
            {
                for(int c=0;c<BoardSize;c++)
                {
                    string TextBoxName = "txt" + r.ToString() + "_" + c.ToString();
                    TextBox t = (TextBox) this.Controls[TextBoxName];
                    if (t == null)
                    {
                        t = new TextBox();
                        t.Name = TextBoxName;
                        t.Size = new Size(26, 22);
                        t.Location = new Point(10 + c * 26, 50 + r * 22);
                        this.Controls.Add(t);
                    }
                    if (Board[r, c] == 0)
                    {
                        t.Text = "";
                        t.BackColor = Color.White;
                    }
                    else
                    {
                        t.Text = String.Format("{0:D2}", Board[r, c]);
                        t.BackColor = Color.Aquamarine;
                    }
                }
            }
            Application.DoEvents();
        }

        private bool IsValid(int [,] Board, Position p)
        {
            if (p.row < 0 || p.row >= BoardSize || p.col < 0 || p.col >= BoardSize)
                return false;
            if (Board[p.row, p.col] != 0)
                return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }



    //tipo posizione cavallo
    struct Position {
        public int row;
        public int col;
    }
}
