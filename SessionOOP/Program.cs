using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SessionOOP
{
    internal class Program
    {
        static List<BankAccount> BankAccounts = new List<BankAccount>();
        static void Main(string[] args)
        {

            BankAccounts.Add(new BankAccount(1, "20241995", "kamelfcis@gmail.com", "01021545454", 1000, "Mohamed kamel"));
            BankAccounts.Add(new BankAccount(2, "20241996", "sara@gmail.com", "01021545454", 1000, "Sara Mohamed"));
            BankAccounts.Add(new BankAccount(3, "20241997", "Mariam@gmail.com", "01021545454", 1000, "Mariam Ahmed"));
            //list dynamic length

            while (true)
            {
                Console.WriteLine("Press 1 To Register New Account\nPress 2 to Show All Accounts\nPress 3 to Make a Transaction");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        AddNewAccount();
                        break;


                    case 2:
                        ShowAllAccount();
                        break;

                    case 3:

                        MakeTransaction();
                        break;
                    default:
                        break;
                }

            }




        }

        private static void MakeTransaction()
        {
            #region
            //Console.WriteLine("Enter Account No : ");
            //string CustomerAccNo = Console.ReadLine();

            //foreach (var acc in BankAccounts)
            //{
            //    if (acc.accountNo == CustomerAccNo)
            //    {
            //        acc.DisplayAccount();
            //        Console.Write("Press w to Withdarwal\nPress d to Deposit\nPress t to transfer");
            //        char transactionChoice=Convert.ToChar(Console.ReadLine());
            //        switch (transactionChoice)
            //        {
            //            case 'w':
            //                Console.Write("Enter withdarwal Amount : ");
            //                double WAmount=Convert.ToDouble(Console.ReadLine());
            //                acc.Withdrawal(WAmount);
            //                break;

            //            case 'd':
            //                Console.Write("Enter Deposit Amount : ");
            //                double DAmount = Convert.ToDouble(Console.ReadLine());
            //                acc.Deposit(DAmount);
            //                break;
            //            case 't':

            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

            #endregion



            #region
            Console.WriteLine("Enter Account No : ");
            string CustomerAccNo = Console.ReadLine();

            var CustomerAcc = BankAccounts.FirstOrDefault(acc => acc.accountNo == CustomerAccNo);
            CustomerAcc.DisplayAccount();
            Console.WriteLine("Press w to Withdarwal\nPress d to Deposit\nPress t to transfer");
            char transactionChoice = Convert.ToChar(Console.ReadLine());
            switch (transactionChoice)
            {
                case 'w':
                    Console.Write("Enter withdarwal Amount : ");
                    double WAmount = Convert.ToDouble(Console.ReadLine());
                    CustomerAcc.Withdrawal(WAmount);
                    break;

                case 'd':
                    Console.Write("Enter Deposit Amount : ");
                    double DAmount = Convert.ToDouble(Console.ReadLine());
                    CustomerAcc.Deposit(DAmount);
                    break;
                case 't':

                    break;
                default:
                    break;
            }

            //foreach (var acc in BankAccounts)
            //{
            //    if (acc.accountNo == CustomerAccNo)
            //    {
            //        acc.DisplayAccount();
            //        Console.Write("Press w to Withdarwal\nPress d to Deposit\nPress t to transfer");
            //        char transactionChoice=Convert.ToChar(Console.ReadLine());
            //        switch (transactionChoice)
            //        {
            //            case 'w':
            //                Console.Write("Enter withdarwal Amount : ");
            //                double WAmount=Convert.ToDouble(Console.ReadLine());
            //                acc.Withdrawal(WAmount);
            //                break;

            //            case 'd':
            //                Console.Write("Enter Deposit Amount : ");
            //                double DAmount = Convert.ToDouble(Console.ReadLine());
            //                acc.Deposit(DAmount);
            //                break;
            //            case 't':

            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}

            #endregion







        }

            private static void ShowAllAccount()
        {
            foreach (var acc in BankAccounts)
            {
                acc.DisplayAccount();
            }

        }

        private static void AddNewAccount()
        {
            BankAccount account = new BankAccount();
            Console.Write("Enter ID : ");
            account.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Full Name : ");
            account.fullName = Console.ReadLine();
            Console.Write("Enter Email : ");
            account.email = Console.ReadLine();
            Console.Write("Enter Phone : ");
            account.phoneNo = Console.ReadLine();
            Console.Write("Enter AccNo : ");
            account.accountNo = Console.ReadLine();
             
            //----------------------------------------------------

            BankAccounts.Add(account);
            Console.WriteLine("Account with Name : {0} Added Successfully", account.fullName);
        }
    }
}
