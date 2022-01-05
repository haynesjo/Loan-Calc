using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan_Calculator
{
    public class Calculator
    {
        //constructor function
        public Calculator()
        {
            mydblInterestRate = 0;
            mydblPrincipal = 0;
            myintLoanLength = 1;
        }
        public Calculator(double Principal, 
            double InterestRate, int LoanLength)
        {
            this.Principal = Principal;
            this.InterestRate = InterestRate;
            this.LoanLength = LoanLength;
        }

        private double mydblPrincipal;

        public double Principal
        {
            get { return mydblPrincipal; }
            set
            {
                if (value > 0)
                {
                    mydblPrincipal = value;
                }
            }

        }

        private double mydblInterestRate;
        private double mydblMonthlyInterestRate;

        public double InterestRate
        {
            get { return mydblInterestRate; }
            set {
                if (value >= 0)
                {
                    if (value > .3)
                    {
                        value = value / 100;
                    }
                    mydblInterestRate = value;
                    mydblMonthlyInterestRate = value / 12;
                }
                }
        }

        private int myintLoanLength = 1;

        public int LoanLength
        {
            get { return myintLoanLength; }
            set {
                if (value > 0)
                {
                    myintLoanLength = value;
                }
                }
        }

        private double mydblMonthlyPayment;

        public double MonthlyPayment
        {
            get {
                //Answer = loanAmount * interestRate / 1 - Math.Pow(1 / 1 + interestRate, loanPeriod);
                double numerator = mydblPrincipal * mydblMonthlyInterestRate;
                double denominator = 1 - 
                    (Math.Pow(1 / (1 + mydblMonthlyInterestRate), 
                        myintLoanLength));
                mydblMonthlyPayment = numerator / denominator;
                return mydblMonthlyPayment; }
        }


    }
}
