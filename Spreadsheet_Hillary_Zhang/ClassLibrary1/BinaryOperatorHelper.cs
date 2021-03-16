using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    public class BinaryOperatorHelper
    {
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
