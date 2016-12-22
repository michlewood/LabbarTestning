using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp;

namespace UnitTestProject1
{
    [TestClass]
    public class DebitTester_UnitTestProject
    {
        [TestMethod]
        public void DebitTester_Removing_200_From_500_And_Expecting_300()
        {
            int expectedOutput = 300;
            int amountToRemove = 200;

            Account account = new Account();
            account.Debit(amountToRemove);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }
        [TestMethod]
        public void DepitTester_Removing_700_From_500_And_Expecting_No_Change()
        {
            int expectedOutput = 500;
            int amountToRemove = 700;

            Account account = new Account();
            account.Debit(amountToRemove);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }

        [TestMethod]
        public void DepitTester_Using_A_Negetive_Number_And_Expecting_No_Change()
        {
            int expectedOutput = 500;
            int amountToRemove = -200;

            Account account = new Account();
            account.Debit(amountToRemove);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }
    }

    [TestClass]
    public class CreditTester_UnitTestProject
    {
        [TestMethod]
        public void CreditTester_Adding_200_From_500_And_Expecting_700()
        {
            int expectedOutput = 700;
            int amountToAdd = 200;

            Account account = new Account();
            account.Credit(amountToAdd);

            Assert.AreEqual(expectedOutput, account.AccountBalance);

        }

        [TestMethod]
        public void CreditTester_Using_A_Negetive_Number_And_Expecting_No_Change()
        {
            int expectedOutput = 500;
            int amountToAdd = -200;

            Account account = new Account();
            account.Credit(amountToAdd);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }

        [TestMethod]
        public void CreditTester_Adding_MaxValue_For_An_Int_To_An_AccountBalance_Over_0_and_Expecting_No_Change()
        {
            int expectedOutput = 500;
            int amountToAdd = int.MaxValue;

            Account account = new Account();
            account.Credit(amountToAdd);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }

        [TestMethod]
        public void CreditTesting_Adding_A_Value_That_Raises_The_AccountBalance_Over_MaxValue_For_Ints()
        {
            int expectedOutput = 500;
            int amountToAdd = int.MaxValue - 300;

            Account account = new Account();
            account.Credit(amountToAdd);

            Assert.AreEqual(expectedOutput, account.AccountBalance);
        }
    }

    [TestClass]
    public class BalanceTester_UnitTestProject
    {
        [TestMethod]
        public void BalanceTest()
        {
            int expectedOutput = 500;
            Account account = new Account();
            int actualOutput = account.Balance();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
