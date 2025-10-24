using System.Linq.Expressions;

namespace AccountNameSpace
{
    public class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string getName() => name;

        public double getBalance() => balance;

        public bool withdraw(double amount, out double remainingBalance)
        {
            remainingBalance = this.balance - amount;
            if (remainingBalance < 0)
                return false;
            this.balance -= amount;
            return true;
        }
    }
}