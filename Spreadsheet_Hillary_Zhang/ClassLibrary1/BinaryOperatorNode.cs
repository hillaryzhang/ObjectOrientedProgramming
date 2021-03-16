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
    // This class is a node that represents a binary operator
    public abstract class BinaryOperatorNode : BaseNode
    {
        private char operate; // the operator symbol: +, -, *, or /
        private BaseNode left, right; // the left and right children nodes of current node
        private char value; // 

        // post: constructs the BinaryOperatorNode with given operator and children nodes
        // char inputedOperator - the given operator symbol: +, -, *, or /
        // BaseNode left - the left child node
        // BaseNode right - the right child node
        public BinaryOperatorNode(char inputedOperator, BaseNode left, BaseNode right)
        {
            this.operate = inputedOperator;
            this.left = left;
            this.right = right;
        }

        // post: constructs the BinaryOperatorNode with a single given value
        // char inputedValue - the given value to set node to
        public BinaryOperatorNode(char inputedValue)
        {
            this.value = inputedValue;
        }

        // post: returns the operator
        public char Operator
        {
            get
            {
                return this.operate;
            }
        }

        // post: returns the left child node and sets it to the value
        public BaseNode Left
        {
            get
            {
                return this.left;
            }

            set
            {
                this.left = value;
            }
        }

        // post: returns the right child node and sets it to the value
        public BaseNode Right
        {
            get
            {
                return this.right;
            }

            set
            {
                this.right = value;
            }
        }

        // post: returns the numerical value of the node given the children nodes
        public abstract double GetNumericalValue(double left, double right);
    }
}
