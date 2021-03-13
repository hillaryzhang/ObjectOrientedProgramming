// Hillary Zhang
// WSU ID: 11694139
// 3/05/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 4: First Steps for your Spreadsheet Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CptS321
{
    /// This class serves as a container for a 2D array of cells. Also serves as a factory for cells (it creates all the cells in the spreadsheet)
    public class Spreadsheet : Cell
    {
        private int rowCount;
        private int columnCount;
        protected Cell[,] spreadsheet;

        public event PropertyChangedEventHandler CellPropertyChanged;
        //public event EventHandler<ProcessEventArgs> CellPropertyChanged;

    /// post : Constructs a spreadsheet that takes a number of rows and columns, and initializes the array of cells with the proper RowIndex and ColumnIndex value
    /// int rows - the given number of rows the spreadsheet will have
    /// int columns - the given number of columns the spreadsheet will have
    public Spreadsheet(int rows, int columns)
        {
            this.rowCount = rows;
            this.columnCount = columns;
            this.spreadsheet = new Cell[rows, columns];

            for (int r = 0; r < rows; r++) //to allocate each row
            {
                for (int c = 0; c < columns; c++) //to allocate each column in each row
                {
                    spreadsheet[r, c] = new CellImplementation(r, c, "");  // 5c.2, give array of cells proper RowIndex and ColumnIndex values 
                    spreadsheet[r, c].PropertyChanged += OnPropertyChanged;  // the spreadsheet class subscribing to all the PropertyChanged events for every cell

                }
            }
        }

        /// post: Updates the value of the cell by checking the text 
        /// object sender - a reference to the control/object that raised the event
        /// PropertyChangedEventArgs e - calls e that contains the property change event data
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
                   
                    string formula = ((Cell)sender).Text.Substring(1); // these three lines is pulling value from another cell by reading in the cell number (ie. "A5") (6c.2)
                    int column = Convert.ToInt16(formula[0]) - 'A';
                    int row = Convert.ToInt16(formula.Substring(1)) - 1;
                    ((Cell)sender).Value = (GetCell(row, column)).Value; 
                }

            }
            CellPropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("Value")); // if PropertyName is Value, update value of cell (6a)
        }

        /// post: returns the cell at the location of the given row and column index (5g)
        /// int rowIndex - the given row index of the cell
        /// int columnIndex -the given columnIndex of the cell
        public Cell GetCell(int rowIndex, int columnIndex)
        {

            if (rowIndex > spreadsheet.GetLength(0) || columnIndex > spreadsheet.GetLength(1))
                return null;
            else
                return spreadsheet[rowIndex, columnIndex];
        }

        /// post: Returns the number of columns in the spreadsheet (5h)
        public int ColumnCount
        {
            get
            {
                return this.columnCount;
            }
        }

        /// post: Returns the number of rows in the spreadsheet (5h)
        public int RowCount
        {
            get
            {
                return this.rowCount;
            }
        }


        /// post: Randomly picks cells to display a message "Hello World!" and sets every cell in the A and B column to display "This is cell B#" where # is the current row of the cell
        public void Demo()
        {
            int i = 0;
            Random rand = new Random();

            while (i < 50) // 7d.1
            {
                int randomColumn = rand.Next(0, 25);
                int randomRow = rand.Next(0, 49);

                Cell toFill = GetCell(randomRow, randomColumn);
                toFill.Text = "Hello World!";
                this.spreadsheet[randomRow, randomColumn] = toFill;
                i++;
            }
            for (i = 0; i < 50; i++) // 7d.2
            {
                this.spreadsheet[i, 1].Text = "This is cell B" + (i + 1);
            }
            for (i = 0; i < 50; i++) // 7d.3
            {
                this.spreadsheet[i, 0].Text = "=B" + (i + 1);
            }

        }
    }
}
