// Hillary Zhang
// WSU ID: 11694139
// 3/12/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 5: Arithmetic Expression Trees (Part 1)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    /* This class is the main entry point to demo my ExpressionTree functionalities within my 
       SpreadsheetEngine dll class */
    class Program
    {
        // post: displays a menu of options for the user to evaluate a given expression or enter their own
        public static void Main(string[] args)
        {
            string userInput = "0";

            ExpressionTree tree = new ExpressionTree("A1-12-C1");

            while (userInput != "4")
            {
                StringBuilder menu = new StringBuilder();
                menu.AppendLine("Menu (current expression = \"" + tree.expression + "\")");
                menu.AppendLine("   1 = Enter a new expression");
                menu.AppendLine("   2 = Set a variable value");
                menu.AppendLine("   3 = Evaluate Tree");
                menu.AppendLine("   4 = Quit");

                Console.WriteLine(menu);

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter new expression: ");
                        string expression = Console.ReadLine();
                        tree = new ExpressionTree(expression);
                        break;
                    case "2":
                        Console.Write("Enter variable name: ");
                        string varName = Console.ReadLine();
                        Console.Write("Enter variable value: ");
                        string varValue = Console.ReadLine();
                        double num;

                        while (!double.TryParse(varValue, out num))
                        {
                            Console.Write("Enter variable value: ");
                            varValue = Console.ReadLine();
                        }

                        tree.SetVariable(varName, num);
                        break;
                    case "3":
                        Console.WriteLine(tree.Evaluate());
                        break;
                }
            }
        }
    }
}
