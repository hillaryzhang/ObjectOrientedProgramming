// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace NUnit.TestHW5
{
    [TestFixture]
    public class TestClassHW5
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
            Assert.AreEqual("4+1+9", this.additionTest.Expression); // Expression: the string value that is set to the expression
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
            Assert.AreEqual(3, this.additionTest.Evaluate());
        }

        // post: makes sure that the given expression matches the final string expression
        [Test]
        public void subtractionTestExpression()
        {
            Assert.AreEqual("11-5-3", this.additionTest.Expression); // Expression: the string value that is set to the expression
        }

        // post: makes sure that subtraction does not yield a null
        [Test]
        public void subtractionTestIsNotNull()
        {
            Assert.IsNotNull(this.additionTest);
        }
    }
}
