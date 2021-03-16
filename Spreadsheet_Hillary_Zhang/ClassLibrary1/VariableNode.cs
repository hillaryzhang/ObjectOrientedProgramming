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
