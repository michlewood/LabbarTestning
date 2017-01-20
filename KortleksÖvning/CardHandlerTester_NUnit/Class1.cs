using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CardHandlerlib;

namespace CardHandlerTester_NUnit
{
    [TestFixture]
    public class Class1
    {
        
        [Test]
        public void Test_If_Input_Is_d_Returns_Diamond()
        {
            var input = 'd';
            var expectedOutput = "Diamond";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_c_Returns_Club()
        {
            var input = 'c';
            var expectedOutput = "Club";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [Test]
        public void Test_If_Input_Is_e_Return_Invalid_input()
        {
            var input = 'e';
            var expectedOutput = "Invalid input";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_C_Returns_Club()
        {
            var input = 'C';
            var expectedOutput = "Club";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
