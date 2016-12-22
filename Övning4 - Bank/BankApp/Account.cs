using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        public int AccountBalance { get; private set; }

        public Account(int accountBalance = 500)
        {
            AccountBalance = accountBalance;
        }
        public void Debit(int amountToRemove)
        {
            if (amountToRemove < AccountBalance && amountToRemove > 0)
            {
                AccountBalance -= amountToRemove; 
            }
        }

        public void Credit(int amountToAdd)
        {
            if (amountToAdd > 0 && amountToAdd + AccountBalance > 0)
            {
                AccountBalance += amountToAdd;
            }
        }

        public int Balance()
        {
            return AccountBalance;
        }
    }
}
