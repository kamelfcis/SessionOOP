using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP
{
    public class BankAccount
    {
        //Properties  --> Variables
        public int id;
        public string accountNo;
        public string email;
        public string phoneNo;
        public double balance { get; private set; }
        public string fullName;
        public List<AccountTransaction> Transactions= new List<AccountTransaction>();


        public BankAccount(int id, string accountNo, string email, string phoneNo, double balance, string fullName)
        {
            this.id = id;
            this.accountNo = accountNo;
            this.email = email;
            this.phoneNo = phoneNo;
            this.balance = balance;
            this.fullName = fullName;
        }

        public BankAccount()
        {
        }




        //behaviors  --> Functions

        public void Withdrawal(double amount)
        {

            this.balance = this.balance - amount;
            Console.WriteLine("this account withdarwal by {0} successfully and the new balance is {1}", amount, balance);
          
            
            Transactions.Add(new AccountTransaction(Transactions.Count+1,DateTime.Now,"Withdrawal",amount));
        }
        public void Deposit(double amount)
        {

            this.balance = this.balance + amount;
            Console.WriteLine("this account deposited by {0} successfully and the new balance is {1}", amount, this.balance);
            Transactions.Add(new AccountTransaction(Transactions.Count + 1, DateTime.Now, "Deposit", amount));
        }

        public void DisplayAccount()
        {
            Console.WriteLine("AccountNo : {0}  --  Full Name : {1}  \tCurrent Balance:{2}", accountNo, fullName, balance);

        }
    }
}
