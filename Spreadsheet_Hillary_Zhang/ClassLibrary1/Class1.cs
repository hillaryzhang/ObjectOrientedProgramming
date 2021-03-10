using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CptS321
{
    /// post: Represents one cell in the worksheet
    public abstract class Cell : INotifyPropertyChanged
    {
        public delegate void PropertyChangedEventHandler(Object sender, PropertyChangedEventArgs e);
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        protected string text = string.Empty;
        protected string value = string.Empty;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value == text) { return; }
                text = value;
                PropertyChanged(this, new PropertyChangedEventArgs(Text));
            }
        }
        public string Value
        {
            get
            {
                return value;
            }
            // implement setter privately somehow?
        }

    }

    /// post: Serves as a container for a 2D array of cells. Also serves as a factory for cells (it creates all the cells in the spreadsheet)
    public class Spreadsheet
    {

    }
}
