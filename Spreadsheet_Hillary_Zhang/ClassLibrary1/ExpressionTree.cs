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
            if (expression.Length != 0)
            {
                int operatorIndex = expression.Length - 1;
                while (operatorIndex > 0 && !OperatorNodeFactory.IsValidOperator(expression[operatorIndex]))
                {
                    operatorIndex--;
                }
                if (OperatorNodeFactory.IsValidOperator(expression[operatorIndex]))
                {
                    BinaryOperatorNode newNode = OperatorNodeFactory.CreateOperatorNode(expression[operatorIndex]);
                    newNode.Left = GetNode(expression.Substring(0, operatorIndex));
                    newNode.Right = GetNode(expression.Substring(operatorIndex + 1));

                    return newNode;
                }
                double number;
                if (double.TryParse(expression, out number))
                {
                    NumericalValueNode newNode = new NumericalValueNode(number);

                    return newNode;
                }
                else
                {
                    VariableNode newNode = new VariableNode(expression);
                    return newNode;
                }
            }
            return null;
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