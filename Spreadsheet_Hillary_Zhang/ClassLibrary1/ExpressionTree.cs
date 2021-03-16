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
            this.root = Compile(expression);  // ??? how to set root
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
            return this.Evaluate(this.root); // ?? how to get "final answer" evaluated single number
            // error has to do with abstract nonabstract/internal class inconsistencies?
        }
    }
}