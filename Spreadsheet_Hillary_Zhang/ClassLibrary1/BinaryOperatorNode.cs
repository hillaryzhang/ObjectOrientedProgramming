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

        public BinaryOperatorNode(char inputedOperator, BaseNode left, BaseNode right)
        {
            this.operate = inputedOperator;
            this.left = left;
            this.right = right;
        }

        public BinaryOperatorNode(char inputedValue)
        {
            this.value = inputedValue;
        }

        public char Operator
        {
            get
            {
                return this.operate;
            }
        }

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

        public abstract double Evaluate(double left, double right);
    }
}
