using System;

static class SavingsAccount
{
        public static float InterestRate(decimal balance)
        {
            float Interest = 0;
            if (balance < 0) {Interest = 3.213f;}
            else if (balance < 1000) { Interest = 0.5f; }
            else if (balance >= 1000 && balance < 5000) { Interest = 1.621f;}
            else if (balance >= 5000) { Interest = 2.475f; }
            return Interest;
        }

    public static decimal Interest(decimal balance) => (decimal)((balance / 100) * (decimal)InterestRate(balance));  

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int YearsBeforeDesiredBalance = 0;
            for (int i = YearsBeforeDesiredBalance; balance < targetBalance; YearsBeforeDesiredBalance++) {balance += Interest(balance);}
            return YearsBeforeDesiredBalance;
        }
}
