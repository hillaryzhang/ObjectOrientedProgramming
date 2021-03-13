// Hillary Zhang
// WSU ID: 11694139
// 3/05/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 4: First Steps for your Spreadsheet Application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CptS321
{
    /// This class manages the actual Winform
    public partial class Form1 : Form
    {
        private Spreadsheet spreadsheet;

        /// post: Initializes the form with the spreadsheet
        public Form1()
        {
            InitializeComponent();
            this.spreadsheet = new Spreadsheet(50, 26);
        }

        /// post: Updates the value of the cell in the UI to match the actual value of the cell
        /// object sender - a reference to the control/object that raised the event
        /// PropertyChangedEventArgs e - calls e that contains the property change event data
        private void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Cell cell = (Cell)sender;
            if (cell != null && e.PropertyName == "Value")
            {
                dataGridView1.Rows[cell.rowIndex].Cells[cell.columnIndex].Value = cell.Value; // ???
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// post: Loads the relevant images including row headers and column headers onto the form
        /// object sender - a reference to the control/object that raised the event
        /// EventArgs e - calls e that contains the event data
        private void Form1_Load(object sender, EventArgs e)
        {
            spreadsheet.CellPropertyChanged += OnCellPropertyChanged; // subscribing to spreadsheet's CellPropertyChanged event

            // columns
            for (char c = 'A'; c <= 'Z'; c++)
            {
                string letter = c.ToString();
                dataGridView1.Columns.Add(letter, letter);
            }

            //rows
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        // post: The buttom that allows the user to see the demo results, including the message "Hello World!" and the A and B columns to display "This is cell B#" where # is the current row of the cell
        private void button1_Click(object sender, EventArgs e)
        {
            spreadsheet.Demo();
        }
    }
}
