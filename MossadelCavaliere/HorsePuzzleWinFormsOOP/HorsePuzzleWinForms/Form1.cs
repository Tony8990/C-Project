using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorsePuzzleWinForms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    static int TriedMoves;

    private void btnGo_Click(object sender, EventArgs e)
    {
      int BoardSize;
      try
      {
        BoardSize = int.Parse(txtBoardSize.Text);
      }
      catch
      {
        BoardSize = 8;
        txtBoardSize.Text = BoardSize.ToString();
      }

      Board board = new Board(BoardSize, BoardSize);

      Position InitialPosition=new Position(0,0);

      int DoneMoves = 0;
      TriedMoves = 0;

      Position CurrentPosition = InitialPosition;
      MarkMove(board, CurrentPosition, ref DoneMoves);

      DateTime dtStart = DateTime.Now;
      MoveHorse(board, CurrentPosition, DoneMoves);
      DateTime dtFinish = DateTime.Now;

      ShowBoard(board);

      MessageBox.Show("Elapsed time: " + dtFinish.Subtract(dtStart).ToString());
      //MessageBox.Show("Tried moves: " + TriedMoves.ToString());
    }

    private void ShowBoard(Board board)
    {
      this.SuspendLayout();
      for (int r = 0; r < board.Rows; r++)
      {
        for (int c = 0; c < board.Columns; c++)
        {
          string TextBoxName = "txt" + r.ToString() + "_" + c.ToString();
          TextBox t = (TextBox)this.Controls[TextBoxName];
          if (t == null)
          {
            t = new TextBox();
            t.Name = TextBoxName;
            t.Size = new Size(26, 22);
            t.Location = new Point(10 + c * 26, 50 + r * 22);
            t.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(t);
          }
          if (!board.GetCell(r, c).IsEmpty)
          {
            t.Text = String.Format("{0:D2}  ", ((Horse)board.GetCell(r, c).HostedPiece).ID);
            t.BackColor = Color.LightGreen;
          }
          else
          {
            t.Text = "";
            t.BackColor = Color.White;
          }

        }
      }
      this.ResumeLayout();
      Application.DoEvents();
    }

    private void MarkMove(Board board, Position MovePosition, ref int DoneMoves)
    {
      DoneMoves++;
      board.SetPieceOnCell(new Horse(DoneMoves, board), MovePosition);

      //ShowBoard(board);
      //Application.DoEvents();
      //System.Threading.Thread.Sleep(2000);
    }

    private void UnmarkMove(Board board, Position MovePosition, ref int DoneMoves)
    {
      board.SetCellEmpty(MovePosition);
      DoneMoves--;

      //ShowBoard(board);
      //Application.DoEvents();
      //System.Threading.Thread.Sleep(2000);
    }

    private bool MoveHorse(Board board, Position CurrentPosition, int DoneMoves)
    {
      if (DoneMoves == board.Size)
        return true;

      Horse CurrentHorse = (Horse)board.GetPieceOnCell(CurrentPosition);

      for (int i = 0; i < CurrentHorse.AvailableMoves; i++)
      {
        Position NextPosition = CurrentHorse.ComputeNextPosition(i);
        BoardCell NextCell = board.GetCell(NextPosition);
        if (NextCell != null && NextCell.IsEmpty)
        {
          MarkMove(board, NextPosition, ref DoneMoves);
          if (MoveHorse(board, NextPosition, DoneMoves))
            return true;
          UnmarkMove(board, NextPosition, ref DoneMoves);
          TriedMoves++;   // Conta tutte le mosse valide
        }
        //TriedMoves++;   // Conta tutte le mosse (valide e non)
      }
      if (TriedMoves % 10000==0)
        ShowBoard(board);
      return false;
    }


  }
}
