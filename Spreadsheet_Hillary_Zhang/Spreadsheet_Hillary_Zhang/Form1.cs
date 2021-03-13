﻿using System;
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
    public partial class Form1 : Form
    {
        private Spreadsheet spreadsheet;
        public Form1()
        {
            InitializeComponent();
            this.spreadsheet = new Spreadsheet(50, 26);
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            spreadsheet.Demo();
        }
    }
}
