using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    // This class is a node that represents a constant numerical value
    public class NumericalValueNode : BaseNode
    {
       public NumericalValueNode(double number)
        {
            this.operatorValue = number;
            this.name = number.ToString(); //I added
        }
    }
}
