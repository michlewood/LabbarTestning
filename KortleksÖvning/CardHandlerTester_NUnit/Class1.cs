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
    public class SuitCheckerTester
    {

        [Test]
        public void Test_If_Input_Is_d_Returns_Diamonds()
        {
            var input = 'd';
            var expectedOutput = "Diamonds";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_Is_c_Returns_Club()
        {
            var input = 'c';
            var expectedOutput = "Clubs";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [Test]
        public void Test_If_Input_Is_e_Return_Invalid_input()
        {
            var input = 'e';
            CardHandler class1 = new CardHandler();
            try
            {
                var actualOutput = class1.SuitChecker(input);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Input is not a valid suit", e.Message);
            }
        }

        [Test]
        public void Test_If_Input_C_Returns_Clubs()
        {
            var input = 'C';
            var expectedOutput = "Clubs";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.SuitChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }

    [TestFixture]
    public class CheckValuesTester
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
            CardHandler class1 = new CardHandler();
            try
            {
                var actualOutput = class1.ValuesChecker(input);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Input is not a valid value", e.Message);
            }
        }
    }

    [TestFixture]
    public class CardCheckerTester
    {
        [Test]
        public void Test_If_Input_2d_Returns_2_of_Diamonds()
        {
            var input = "2d";
            var expectedOutput = "2 of Diamonds";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.CardChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_10d_Returns_10_of_Diamonds()
        {
            var input = "10d";
            var expectedOutput = "10 of Diamonds";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.CardChecker(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_10ddd_Returns_Invalid_input()
        {
            var input = "10ddd";
            CardHandler class1 = new CardHandler();
            try
            {
                var actualOutput = class1.CardChecker(input);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Input is wrong length", e.Message);
            }
        }

        [Test]
        public void Test_If_Input_1dd_Returns_Invalid_input()
        {
            var input = "1dd";
            var expectedOutput = "1 Of Diamonds";
            CardHandler class1 = new CardHandler();
            var actualOutput = class1.CardChecker(input);
            Assert.AreNotEqual(expectedOutput, actualOutput);
        }
    }
}
