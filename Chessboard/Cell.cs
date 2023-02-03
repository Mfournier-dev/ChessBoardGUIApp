using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class Cell
    {
        //Propriétés de Cell
        public int RankNumber { get; set; }
        public int FileNumber { get; set; }
        public bool CurrentlyOccupied { get; set; }
        public bool LegalNextMove { get; set; }


        //Constructeur
        public Cell(int x, int y)
        {
            RankNumber = x;
            FileNumber = y;
        }
    }
}
