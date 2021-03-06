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
    // This class is a node that represents a constant numerical value
    public class NumericalValueNode : BaseNode
    {
       // post: constructs the NumericalValueNode with the given number
       // double number - the given number that is the numerical value of the node
       public NumericalValueNode(double number)
        {
            this.operatorValue = number;
            this.name = number.ToString(); // I added
        }
    }
}
