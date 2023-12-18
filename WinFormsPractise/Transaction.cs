using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WinFormsPractise
{
    internal abstract class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }

        public abstract void ProcessTransaction(Account account);
    }
    
}
