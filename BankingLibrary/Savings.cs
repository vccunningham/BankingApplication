using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Savings : InterestBearingAccount {




        public Savings(double InterestRate) : base(InterestRate) {

        }
        public Savings() : base() {
            Description = "Savings";

        }
    }
}
