// Hillary Zhang
// WSU ID: 11694139
// 3/05/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 4: First Steps for your Spreadsheet Application

// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using CptS321;

namespace NUnit.Tests1
{
    /// This class makes sure the spreadsheet engine creates and updates the spreadsheet correctly
    [TestFixture]
    public class TestClass 
    {

        [Test]
        public void TestSpreadsheetEdgeCase()
        {
            // Spreadsheet spreadsheet = new Spreadsheet(0, 0);
            
        }

        [Test]
        public void TestCellEqualValue()
        {
            /*Spreadsheet sheet = new Spreadsheet(25, 25);
            

            for (int i = 0; i < 25; i++) // 7d.2
            {
                spreadsheet[i, 1].Text = "This is cell B" + (i + 1);
            }
            for (int i = 0; i < 25; i++) // 7d.3
            {
                spreadsheet[i, 0].Text = "=B" + (i + 1);
            }  */
        } 
    }
}
