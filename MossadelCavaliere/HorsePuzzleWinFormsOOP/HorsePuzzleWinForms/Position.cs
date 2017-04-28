using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsePuzzleWinForms
{
  public class Position
  {
    public int Row = 0;
    public int Column = 0;

    public Position()
    { }

    public Position(int row, int col)
    {
      this.Row = row;
      this.Column = col;
    }

  }
}
