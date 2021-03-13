
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
        public int rowIndex { get; set; }
        public int columnIndex { get; set; }
        protected string text = string.Empty;
        protected string value = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

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
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}



