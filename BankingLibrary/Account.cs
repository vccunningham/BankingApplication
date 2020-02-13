using System;

namespace BankingLibrary {



    public class Account {

        private static int NextAccountNbr = 1;
        private const int AccountNbrInc = 9;

        
        public decimal Balance { get; set; }
        public int AccountNbr { get; private set; }
        public string Description { get; set; } = "Account";

        private int AttemptsToOverdraw = 0;
        
        //create a static variable
        

        private bool CheckAmountGTZero (decimal amount) {
            // ternary operator, // return (amount <= 0) ? false : true;
            // if you have to do more work, use 'if' statement
            if(amount <= 0) {
                return false;
            }
            else {
                return true;
            }
        }

        public void Deposit(decimal amount) {
            if (CheckAmountGTZero(amount)) {
                Balance += amount;
            }
        }
        public bool Withdraw(decimal amount) {
            
            if (CheckAmountGTZero(amount) && IsSufficientFunds(amount)) {
                Balance -= amount;
                return true;
            }
            return false;
        }

        private bool IsSufficientFunds(decimal amount) {
            //return (Balance >= amount) ? true : false;
            if (Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        public void Transfer(decimal amount, Account toAccount) {

            if (this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }
                
        }

        public override string ToString() {
            return $"Account Number = {AccountNbr}, Description= {Description}, Bal={Balance}";
            // '=>' means Lambda
        }

        public void Debug() {
            Console.WriteLine(this);
        }

        public Account() {
            this.AccountNbr = NextAccountNbr;
            NextAccountNbr += AccountNbrInc;
            
        }

    }


}
