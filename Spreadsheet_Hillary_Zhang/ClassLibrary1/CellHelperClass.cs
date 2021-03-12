using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CptS321
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
