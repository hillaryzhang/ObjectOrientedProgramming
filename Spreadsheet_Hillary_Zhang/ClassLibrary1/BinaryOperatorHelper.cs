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
    // This class represents four types of BinaryOperatorNodes
    public class BinaryOperatorHelper
    {
        // This class represents a node that is the sum of addition of two nodes
        internal class AdditionNode : BinaryOperatorNode
        {
            public AdditionNode() : base('+')
            {
            }

            public override double GetNumericalValue(double left, double right)
            {
                return left + right;
            }
        }

        // This class represents a node that is the difference of subtraction of two nodes
        internal class SubtractionNode : BinaryOperatorNode
        {
            public SubtractionNode() : base('-')
            {
            }
            public override double GetNumericalValue(double left, double right)
            {
                return left - right;
            }
        }

        // This class represents a node that is the product of multiplication of two nodes
        internal class MultiplicationNode : BinaryOperatorNode
        {
            public MultiplicationNode() : base('*')
            {
            }
            public override double GetNumericalValue(double left, double right)
            {
                return left * right;
            }
        }

        // This class represents a node that is the quotient of division of two nodes
        internal class DivisionNode : BinaryOperatorNode
        {
            public DivisionNode() : base('/')
            {
            }
            public override double GetNumericalValue(double left, double right)
            {
                return left / right;
            }
        }
    }
}
