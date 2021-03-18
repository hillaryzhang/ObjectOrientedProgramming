﻿// Hillary Zhang
// WSU ID: 11694139
// 3/12/2021
// CptS 321
// Professor: Venera Arnaoudova
// Assignment 5: Arithmetic Expression Trees (Part 1)

// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace NUnit.Test
{
    [TestFixture]
    public class ExpressionTreeTest
    {
        private CptS321.ExpressionTree additionTest = new CptS321.ExpressionTree("4+1+9");

        // post: makes sure that addition yields the correct value based on the given addition expression
        [Test]
        public void additionTestEvaluate()
        {
            Assert.AreEqual(14, this.additionTest.Evaluate());
        }
        
        // post: makes sure that the given expression matches the final string expression
        [Test]
        public void additionTestExpression()
        {
            Assert.AreEqual("4+1+9", this.additionTest.expression); // Expression: the string value that is set to the expression
        }

        // post: makes sure that addition does not yield a null
        [Test]
        public void additionTestIsNotNull()
        {
            Assert.IsNotNull(this.additionTest);
        }

        private CptS321.ExpressionTree subtractionTest = new CptS321.ExpressionTree("11-5-3");

        // post: makes sure that subtraction yields the correct value based on the given subtraction expression
        [Test]
        public void subtractionTestEvaluate()
        {
            Assert.AreEqual(3, this.subtractionTest.Evaluate());
        }

        // post: makes sure that the given expression matches the final string expression
        [Test]
        public void subtractionTestExpression()
        {
            Assert.AreEqual("11-5-3", this.subtractionTest.expression); // Expression: the string value that is set to the expression
        }

        // post: makes sure that subtraction does not yield a null
        [Test]
        public void subtractionTestIsNotNull()
        {
            Assert.IsNotNull(this.subtractionTest);
        }

        private CptS321.ExpressionTree multiplicationTest = new CptS321.ExpressionTree("10*2*4");

        // post: makes sure that multiplication yields the correct value based on the given expression
        [Test]
        public void multiplicationTestEvaluate()
        {
            Assert.AreEqual(80, this.multiplicationTest.Evaluate());
        }

        // post: makes sure that the given expression matches the final string expression
        [Test]
        public void multiplicationTestExpression()
        {
            Assert.AreEqual("10*2*4", this.multiplicationTest.expression); // Expression: the string value that is set to the expression
        }

        // post: makes sure that multiplication does not yield a null
        [Test]
        public void multiplicationTestIsNotNull()
        {
            Assert.IsNotNull(this.multiplicationTest);
        }

        private CptS321.ExpressionTree divisionTest = new CptS321.ExpressionTree("10/2/5");

        // post: makes sure that division yields the correct value based on the given expression
        [Test]
        public void divisionTestEvaluate()
        {
            Assert.AreEqual(1, this.divisionTest.Evaluate());
        }

        // post: makes sure that the given expression matches the final string expression
        [Test]
        public void divisionTestExpression()
        {
            Assert.AreEqual("10/2/5", this.divisionTest.expression); // Expression: the string value that is set to the expression
        }

        // post: makes sure that division does not yield a null
        [Test]
        public void divisionTestIsNotNull()
        {
            Assert.IsNotNull(this.divisionTest);
        }

        private CptS321.ExpressionTree mixedOperatorAddSubtractTest = new CptS321.ExpressionTree("5 - 7 + 5");

        private CptS321.ExpressionTree mixedOperatorMultDivideTest = new CptS321.ExpressionTree("5 * 7 / 5");

        private CptS321.ExpressionTree parenthesisAddSubtractTest = new CptS321.ExpressionTree("5 - (7 + 5)");

        private CptS321.ExpressionTree parenthesisMultDivideTest = new CptS321.ExpressionTree("5 * (7 / 5)");


    }
}