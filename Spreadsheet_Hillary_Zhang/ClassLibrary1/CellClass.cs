
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

        public event PropertyChangedEventHandler PropertyChanged;

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
                
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
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
                    
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged();
                }
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}



