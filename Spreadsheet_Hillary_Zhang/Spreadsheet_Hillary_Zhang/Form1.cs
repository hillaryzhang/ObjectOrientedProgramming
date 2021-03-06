using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_Hillary_Zhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable datatable = new DataTable();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                string letter = c.ToString();
                datatable.Columns.Add(new DataColumn(letter, typeof(string)));
            }
        }
    }
}
