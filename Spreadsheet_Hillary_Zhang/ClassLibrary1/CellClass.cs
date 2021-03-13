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
    /// This class represents one cell in the worksheet
    public abstract class Cell : INotifyPropertyChanged
    {
        public int rowIndex { get; set; }
        public int columnIndex { get; set; }
        protected string text = string.Empty;
        protected string value = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// post: Returns and updates the text of the cell
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                if (value == this.text) { return; }
                this.text = value;

                // Call PropertyChanged whenever the property is updated
                PropertyChanged(this, new PropertyChangedEventArgs("Text"));
            }
        }

        /// post: Returns and updates the value of the cell
        public string Value
        {
            get
            {
                return this.value;
            }
            protected internal set
            {
                if (value == this.value)
                    return;
                else
                {
                    this.value = value;

                    // Call PropertyChanged whenever the property is updated
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }

        /// post: Updates the text or value of the cell 
        /// string name - the indicator of whether it is the text or value that needs updated
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}



