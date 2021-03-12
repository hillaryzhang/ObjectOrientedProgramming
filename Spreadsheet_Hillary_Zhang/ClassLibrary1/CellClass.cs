
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
        public int rowIndex { get; set; }
        public int columnIndex { get; set; }
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
                PropertyChanged(this, new PropertyChangedEventArgs("Text"));
            }
        }
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
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }

    }
}



