using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePuzzleWinForms
{
  public class Horse : Chessman
  {
    public int ID;

    public Horse(int ID, Board board)
    {
      this.ID = ID;
      this.pHostingBoard = board;
      MoveOffsets = new int[8, 2] { { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 }, { -1, -2 }, { 1, -2 }, { 2, -1 } };
    }
  }

}
