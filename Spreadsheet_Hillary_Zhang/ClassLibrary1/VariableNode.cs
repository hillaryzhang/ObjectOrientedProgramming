using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    // This class is a node that represents a variable
    public class VariableNode : BaseNode
    {
        // post: constructs the VariableNode with the given variable name
        // string variableName - the given name that is the name of the variable
        public VariableNode(string variableName)
        {
            this.name = variableName;
        }
    }
}
