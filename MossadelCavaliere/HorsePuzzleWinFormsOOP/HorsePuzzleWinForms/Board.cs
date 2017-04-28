using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePuzzleWinForms
{
  public class Board
  {
    List<BoardCell> Cells = new List<BoardCell>();
    public int Rows;
    public int Columns;
    
    public int Size   // This property is read-only
    {
      get 
      {
        return Rows * Columns;
      }
    }

    public Board (int rows, int cols)
    {
      Rows = rows;
      Columns = cols;
      for (int r = 0; r < Rows; r++)
        for (int c = 0; c < Columns; c++)
        Cells.Add( new BoardCell(r, c));
    }

    public BoardCell GetCellHostingPiece(Chessman Piece)
    {
      foreach (BoardCell c in Cells)
        if (!c.IsEmpty)
          if (c.HostedPiece == Piece)
            return c;
      return null;
    }

    public bool SetPieceOnCell(Chessman piece, int row, int col)
    {
      if (row < 0 || row >= Rows || col < 0 || col >= Columns)
        return false;    // Indexes outside the board
      Cells.ElementAt<BoardCell>(Columns * row + col).SetPieceOnCell(piece);
      return true;
    }
    
    public bool SetPieceOnCell(Chessman piece, Position pos)
    {
      return SetPieceOnCell( piece, pos.Row, pos.Column);
    }

    public Chessman GetPieceOnCell(int row, int col)
    {
      if (row < 0 || row >= Rows || col < 0 || col >= Columns)
        return null;    // Indexes outside the board
      return Cells.ElementAt<BoardCell>(Columns * row + col).HostedPiece;
    }

    public Chessman GetPieceOnCell(Position pos)
    {
      return GetPieceOnCell(pos.Row, pos.Column);
    }

    public bool SetCellEmpty(int row, int col)
    {
      if (row < 0 || row >= Rows || col < 0 || col >= Columns)
        return false;    // Indexes outside the board
      SetPieceOnCell(null, row, col);
      return true;
    }

    public bool SetCellEmpty(Position pos)
    {
      return SetPieceOnCell(null, pos);
    }

    public BoardCell GetCell(int row, int col)
    {
      if (row < 0 || row >= Rows || col < 0 || col >= Columns)
        return null;    // Indexes outside the board
      return Cells.ElementAt<BoardCell>(Columns * row + col);
    }

    public BoardCell GetCell(Position pos)
    {
      return GetCell(pos.Row, pos.Column);
    }

  }
}
