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
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    // This class serves as a factory for the OperatorNode class
    internal class OperatorNodeFactory
    {
        // post: creates and returns a new BinaryOperatorNode based on the type of operator
        // char theOperator - the given operator: +, -, *, or /
        public static BinaryOperatorNode CreateOperatorNode(char theOperator)
        {
            switch (theOperator)
            {
                case '+':
                    return new BinaryOperatorHelper.AdditionNode();
                case '-':
                    return new BinaryOperatorHelper.SubtractionNode();
                case '*':
                    return new BinaryOperatorHelper.MultiplicationNode();
                case '/':
                    return new BinaryOperatorHelper.DivisionNode();
            }
            return null;
        }

        // post: returns whether the given operator is a valid operator
        // char theOperator - the given operator: should be +, -, *, or /
        public static bool IsValidOperator(char theOperator)
        {
            switch (theOperator)
            {
                case '-':
                    return true;
                case '+':
                    return true;
                case '*':
                    return true;
                case '/':
                    return true;
            }
            return false;
        }
    }
}
