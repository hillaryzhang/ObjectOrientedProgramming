using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CellImplementation : Cell
    {
        public CellImplementation(int rows, int col, string text)
        {
            rowIndex = rows;
            columnIndex = col;
            this.text = text;
            value = text;
        }
    }
}
