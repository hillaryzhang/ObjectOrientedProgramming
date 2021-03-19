// Hillary Zhang
// WSU ID: 11694139
// 3/12/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 5: Arithmetic Expression Trees (Part 1)

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    /* This class represents an expression tree, aka. a binary tree representation of an English expression 
       consisting of variables, numerical values, and binary operators */
    public class ExpressionTree
    {
        protected Dictionary<string, double> variables; // stores the variables and corresponding numerical value
        public string expression; // the given string expression 
        private BaseNode root; // the root node of the expression tree

        // post: constructs a tree from a given specific expression
        // string expression - the given expression to construct a tree from
        public ExpressionTree(string expression)
        {
            this.root = GetNode(expression);  
            this.variables = new Dictionary<string, double>();
            this.expression = expression;
        }

        // post: sets the specified variable within the ExpressionTree variables dictionary
        // string variableName - the given name of the variable
        // double variableValue - the given numerical value of the variable
        public void SetVariable(string variableName, double variableValue)
        {
            this.variables[variableName] = variableValue;
        }

        // post: evaluates the expression to a double value
        public double Evaluate()
        {
            return this.GetNumericalValue(this.root); 
        }


        // Additional methods outside of given three below

        // post: creates and returns a node in the expression tree that represents the given variable
        // string variable - the given variable to set the node to 
        private static BaseNode BuildVariableNode(string variable)
        {
            double num;
            if (double.TryParse(variable, out num))
            {
                return new NumericalValueNode(num);
            }

            VariableNode node = new VariableNode(variable);
            return new VariableNode(variable);
        }

        // post: creates and returns a node in the expression tree based on the given expression
        // string expression - the given english expression that may consist of letters, numbers, and operators
        private static BaseNode GetNode(string expression)
        {
            expression = expression.Replace(" ", "");
            int counter = 1, i = 0;
            if (expression[i] == '(')
            {
                for (i = 1; expression.Length > i; i++)
                {
                    if (expression[i] == '(')
                    {
                        counter++;
                    }
                    else if (expression[i] == ')')
                    {
                        counter--;
                        if (counter == 0)
                        {
                            if (i == expression.Length - 1)
                            {
                                return GetNode(expression.Substring(1, expression.Length - 2));
                            }
                            break;
                        }
                    }
                }
                if (counter != 0)
                {
                    throw new System.ArgumentException("Too many or too few parentheses", "Invalid Expression");
                }
            }
            int index = GetLowestOperatorPrecedenceIndex(expression);
            return GetNodeHelper(index, expression);
        }

        // post: helps returns a node in the expression tree based on the given expression
        // int index - the index of the lowest precedence operator in the expression
        // string expression - the given english expression that may consist of letters, numbers, and operators
        private static BaseNode GetNodeHelper(int index, string expression)
        {
            if (index != -1)
            {
                BinaryOperatorNode node = OperatorNodeFactory.CreateOperatorNode(expression[index]);
                node.Right = GetNode(expression.Substring(index + 1));
                node.Left = GetNode(expression.Substring(0, index));
                return node;
            }
            else if (index == -2)
            {
                throw new System.ArgumentException("Too many or too few parentheses", "Invalid expression");
            }
            return BuildVariableNode(expression);
        }

        // post: finds and returns the index of the operator with the lowest precedence in the expression
        // string expression - the given english expression that may consist of letters, numbers, and operators
        public static int GetLowestOperatorPrecedenceIndex(string expression)
        {
            int parenthesisCounter = 0, lowestOperatorIndex = -1, i = expression.Length - 1;
            for (; i >= 0; i--)
            {
                switch (expression[i])
                {
                    case '+':
                    case '-':
                        if (parenthesisCounter == 0)
                        {
                            return i;
                        }
                        break;
                    case '*':
                    case '/':
                        if (parenthesisCounter == 0 && lowestOperatorIndex == -1)
                        {
                            lowestOperatorIndex = i;
                        }
                        break;
                    case '(':
                        parenthesisCounter++;
                        break;
                    case ')':
                        parenthesisCounter--;
                        break;
                }
            }
            if (parenthesisCounter == 0)
            {
                return lowestOperatorIndex;
            }
            else
            {
                throw new System.ArgumentException("Too many or too few parentheses", "Invalid Expression");
            }
        }


        // post: returns the numerical value of a given node
        // BaseNode node - the given node to get the numerical value of 
        private double GetNumericalValue(BaseNode node)
        {
            if (node != null && node is BinaryOperatorNode)
            {
                BinaryOperatorNode temp = (BinaryOperatorNode)node;

                return temp.GetNumericalValue(this.GetNumericalValue(temp.Left), this.GetNumericalValue(temp.Right));
            }

            if (node != null && node is VariableNode)
            {
                try
                {
                    return this.variables[node.Name];
                }
                catch
                {
                    throw new System.ArgumentException("Variable " + node.Name + " has not been defined.", "Variable Not Defined");
                }
            }

            if (node != null && node is NumericalValueNode)
            {
                NumericalValueNode temp = (NumericalValueNode)node;
                return temp.OperatorValue;
            }
            return 0;
        }
    }
}