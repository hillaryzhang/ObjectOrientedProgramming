using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CptS321
{
    /// post: Serves as a container for a 2D array of cells. Also serves as a factory for cells (it creates all the cells in the spreadsheet)
    public class Spreadsheet : Cell
    {
        private int rowCount;
        private int columnCount;
        protected Cell[,] spreadsheet;

        public event PropertyChangedEventHandler CellPropertyChanged;

        /// post: Constructs a spreadsheet that takes a number of rows and columns, and initializes the array of cells with the proper RowIndex and ColumnIndex value
        public Spreadsheet(int rows, int columns)
        {
            this.rowCount = rows;
            this.columnCount = columns;
            this.spreadsheet = new Cell[rows, columns];

            for (int r = 1; r <= rows; r++) //to allocate each row
            {
                for (int c = 1; c <= columns; c++) //to allocate each column in each row
                {
                    spreadsheet[r, c] = new CellImplementation(r, c, "");  // 5c.2, give array of cells proper RowIndex and ColumnIndex values 
                    spreadsheet[r, c].PropertyChanged += OnPropertyChanged;  // the spreadsheet class subscribing to all the PropertyChanged events for every cell

                }
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Text")
            {
                if(!((Cell)sender).Text.StartsWith("=")) //6b
                {
                    ((Cell)sender).Value = ((Cell)sender).Text;
                    
                }
                else //6c
                {
                   
                    string formula = ((Cell)sender).Text.Substring(1);
                    int column = Convert.ToInt16(formula[0]) - 'A';
                    int row = Convert.ToInt16(formula.Substring(1)) - 1;
                    ((Cell)sender).Value = (GetCell(row, column)).Value;
                }

            }
            CellPropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("Value"));
        }

        // post: returns the cell at the location of the given row and column index (5g)
        public Cell GetCell(int rowIndex, int columnIndex)
        {

            if (rowIndex > spreadsheet.GetLength(0) || columnIndex > spreadsheet.GetLength(1))
                return null;
            else
                return spreadsheet[rowIndex, columnIndex];
        }

        // post: Returns the number of columns in the spreadsheet (5h)
        public int ColumnCount
        {
            get
            {
                return this.columnCount;
            }
        }

        // post: Returns the number of rows in the spreadsheet (5h)
        public int RowCount
        {
            get
            {
                return this.rowCount;
            }
        }
    }
}
