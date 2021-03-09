using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    /// post: Represents one cell in the worksheet
    public abstract class Cell
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        protected string text;
        public string Text { get; }
        public string Text(string newText)
        {
            set
        }
        public string Text()
        {
            get { return text; }
        }
        public string Text(string newText)
        {
            this.text = newText;

        }
    }

    /// post: Serves as a container for a 2D array of cells. Also serves as a factory for cells (it creates all the cells in the spreadsheet)
    public class Spreadsheet
    {

    }
}
