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
    public class SuitChecker
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

    [TestFixture]
    public class CheckValues
    {
        [Test]
        public void Test_If_Input_Is_2_Returns_2()
        {
            var input = "2";
            var expectedOutput = "2";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_10_Returns_10()
        {
            var input = "2";
            var expectedOutput = "2";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_1_Returns_Ace()
        {
            var input = "1";
            var expectedOutput = "Ace";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_J_Returns_Jack()
        {
            var input = "J";
            var expectedOutput = "Jack";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_q_Returns_Queen()
        {
            var input = "q";
            var expectedOutput = "Queen";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_e_Returns_Invalid_value()
        {
            var input = "e";
            var expectedOutput = "Invalid value";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.ValuesChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
