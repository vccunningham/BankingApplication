using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public void CalculateInterest(int Months) {
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            Deposit(interest);
            Console.WriteLine($"Calculated Interest = {interest}");
        }

        public override string ToString() {
            //return base.ToString() + $" Interest Rate= {InterestRate}";
            return $" {base.ToString()} + Interest Rate={InterestRate}";
        }
        public InterestAccount(double interestRate) : this() {
            InterestRate = Convert.ToDecimal(interestRate);
            //Convert is what you want to change the method into
        }
        public InterestAccount() : base() {

            this.Description = "Interest Account";


        }
        

        


    }

}
