using System;
using System.Collections.Generic;
using BankingLibrary;

namespace BankingApplication {

    class Program {
        static void Main(string[] args) {

            var sav1 = new Savings(0.01);
            sav1.Debug();
            
            


            var int1 = new InterestAccount(0.12);
            int1.Deposit(100);
            int1.CalculateInterest(3);
            int1.Debug();
            
            // 'm' means treat as a decimal


            var Chk1 = new Checking();
            Chk1.Deposit(100);
            Chk1.Withdraw(75);
            Chk1.Deposit(-10);
            Chk1.Withdraw(1000);
            Chk1.Deposit(0);
            Chk1.Withdraw(100);

            var Chk2 = new Checking();
            Chk2.Deposit(200);
            Chk2.Withdraw(40);

            //Chk1.Debug();
            //Chk2.Debug();
            
            Chk2.Transfer(100, Chk1);
            //Chk1.Debug();
            //Chk2.Debug();

            var accounts = new List<Account>();
            accounts.Add(sav1);
            accounts.Add(int1);
            //accounts.Add(Chk2);
            //accounts.Add(Chk1);

        }
    }
}
