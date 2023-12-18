using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WinFormsPractise
{
    internal class Deposit : Transaction
    {
        public override void ProcessTransaction(Account acc)
        {
            acc.Balance += TransactionAmount;
        }
    }
}
