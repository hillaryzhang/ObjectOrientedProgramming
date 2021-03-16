using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    internal class OperatorNodeFactory
    {
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
