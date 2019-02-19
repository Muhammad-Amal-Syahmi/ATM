using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class Account
    {
        private int pin_number;
        private double balance;

        public void Check_balance() {
            string message = "Your balance : RM" + balance;
        }
        public virtual void withdraw(double amount)
        {
            double withdraw_amount = amount;
            string message;

            if (amount > balance)
            {
                message = "Insufficient balance";
            }
            else {
                message = "Dispensing money......";
                balance = balance - withdraw_amount;
            }
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
        }
        public abstract void transfer_money(double amount, int bank_number, string bank_type);
        public void change_pin(int new_pin)
        {
            pin_number = new_pin;
        }

        public double getBalance() { return balance; }
        public void setBalance(double x) { balance = x; }
    }
}
