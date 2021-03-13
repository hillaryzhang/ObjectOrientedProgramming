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
    /// This class helps the Spreadsheet class access the cell 
    public class CellImplementation : Cell
    {
        /// post: Initializes the cell with the given number of rows, number of columns, and text 
        /// int rows - The given number of rows in the spreadsheet
        /// int col - The given number of columns in the spreadsheet
        /// string text - The given text within the cell
        public CellImplementation(int rows, int col, string text)
        {
            rowIndex = rows;
            columnIndex = col;
            this.text = text;
            value = text;
        }
    }
}
