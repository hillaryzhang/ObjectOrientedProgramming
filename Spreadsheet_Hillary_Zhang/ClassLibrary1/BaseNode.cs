﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace CptS321
{
    /* This class represents the base node that the three types of nodes (constant numerical value, 
    variable, binary operator) build from */
    public abstract class BaseNode
    {
        protected string name; // to be set in the three node classes that inherit from the base node, 
                               // indicates what type of node it is (numerical value, variable, or operator)
        protected double operatorValue; // to be set in the three node classes that inherit from the base node, 
                                        // indicates what the numerical value for operating is 
        
        // post: gets and sets the name of the node
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name == value)
                {
                    return;
                }
                else
                {
                    this.name = value;
                }
            }
        }

        // post: gets and sets the numerical value of the node for operating 
        public double OperatorValue
        {
            get
            {
                return this.operatorValue;
            }

            set
            {
                if (this.operatorValue == value)
                {
                    return;
                }
                else
                {
                    this.operatorValue = value;
                }
            }
        }
    }
}
