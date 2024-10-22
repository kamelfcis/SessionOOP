using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP
{
   public class AccountTransaction
    {
        public AccountTransaction(int id, DateTime transactionDate, string type, double amount)
        {
            Id = id;
            TransactionDate = transactionDate;
            Type = type;
            Amount = amount;
        }

        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }

        public double Amount { get; set; }
    }
}
