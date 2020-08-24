﻿using System;
using System.Collections.Generic;
using Exemplo_Heranca.Entities;
namespace Exemplo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //    BusinessAccount account = new BusinessAccount(9010, "Bob Brown", 100.0, 500.0);


            //    Account acc = new Account(1001, "Alex", 0.0);
            //    BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //    //UPCASTING
            //    Account acc1 = bacc;
            //    Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //    Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //    //DOWNCASTING
            //    BusinessAccount acc4 = (BusinessAccount)acc2;
            //    acc4.Loan(100.0);

            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    if (acc3 is BusinessAccount)
            //    {

            //        BusinessAccount acc5 = acc3 as BusinessAccount;
            //        acc5.Loan(200.0);
            //        Console.WriteLine("Loan!!");
            //    }
            //    if (acc3 is SavingsAccount)
            //    {
            //        //SavingsAccount acc5 = (SavingsAccount)acc3;
            //        SavingsAccount acc5 = acc3 as SavingsAccount;
            //        acc5.updateBalance();
            //        Console.WriteLine("Update");
            //    }
            //    Account acc6 = new Account(1001, "Alex", 500); ;
            //    Account acc7 = new SavingsAccount(1002, "Anna", 500, 0.01);

            //    acc6.Withdraw(10.0);
            //    acc7.Withdraw(10.0);

            //    Console.WriteLine(acc6.Balance);
            //    Console.WriteLine(acc7.Balance);
            //

            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));


            double sum = 0;

            foreach (Account acc in list) {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: "+ sum.ToString());


            foreach (Account acc in list) {

                acc.Withdraw(10.0);

            }
            foreach (Account acc in list) {
                Console.WriteLine("Update Balance for account: "+ acc.Number+ ":"+
                    acc.Balance.ToString());
            }
        }

    }
}
