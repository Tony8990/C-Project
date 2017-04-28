using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePuzzleWinForms
{
  public class BoardCell
  {
    Chessman pHostedPiece=null;
    Position pPosOnBoard = null;

    public BoardCell(int row, int col)
    {
      pPosOnBoard = new Position(row, col);
    }

    public bool IsEmpty   // This property is read-only
    {
      get {
        if (pHostedPiece == null)
          return true;
        else
          return false;
      }
    }

    public void SetPieceOnCell(Chessman p)
    {
      pHostedPiece = p;
    }

    public Chessman HostedPiece   // This property is read-only
    {
      get
      {
        return pHostedPiece;
      }
    }

    public Position CellPosition   // This property is read-only
    {
      get
      {
        return pPosOnBoard;
      }
    }

  }

}
