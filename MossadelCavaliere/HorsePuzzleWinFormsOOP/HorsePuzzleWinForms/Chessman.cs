using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePuzzleWinForms
{
  public abstract class Chessman
  {
    protected Board pHostingBoard;

    public virtual Board HostingBoard
    {
      get
      {
        return pHostingBoard;
      }
      set
      {
        pHostingBoard = value;
      }
    }

    protected int[,] MoveOffsets;
    public virtual Position ComputeNextPosition(int MoveIndex)
    {
      Position CurrentPosition = pHostingBoard.GetCellHostingPiece(this).CellPosition;

      // Position NextPosition = CurrentPosition; // NO!

      Position NextPosition = new Position(CurrentPosition.Row, CurrentPosition.Column);
      NextPosition.Column += MoveOffsets[MoveIndex, 0];
      NextPosition.Row += MoveOffsets[MoveIndex, 1];
      return NextPosition;
    }

    public int AvailableMoves
    {
      get
      {
        return MoveOffsets.GetUpperBound(0) + 1;
      }
    }

  }
}
