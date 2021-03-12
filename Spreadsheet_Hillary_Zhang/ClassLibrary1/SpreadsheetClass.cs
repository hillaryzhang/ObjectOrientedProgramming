using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// post: Serves as a container for a 2D array of cells. Also serves as a factory for cells (it creates all the cells in the spreadsheet)
    public class Spreadsheet
    {
        private int rowCount;
        private int columnCount;
        protected Cell[,] spreadsheet;
        public event PropertyChangedEventHandler CellPropertyChanged;

        // 5c
        public Spreadsheet(int rows, int col)
        {
            this.rowCount = rows;
            this.columnCount = col;
            spreadsheet = new Cell[rows, col];

            for (int r = 1; r <= rows; r++) //to allocate each row
            {
                for (char c = 'A'; c <= (char)col; c++) //to allocate each column in each row
                {
                    //5c.2, give array of cells proper RowIndex and ColumnIndex values

                }
            }

        }
    }
}
