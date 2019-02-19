using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Saving_Account_Interface : IAccount
    {
        public int pin_number { get; set; }
        public double balance { get; set; }

        public void withdraw(double amount)
        {
            double maximum_amount = 5000;
            double withdraw_amount = amount;
            string message;
            if (amount > balance)
            {
                message = "Insufficient balance";
            }
            else if (withdraw_amount > maximum_amount)
            {
                message = "You are not allowed to withdraw over RM" + maximum_amount;
            }
            else
            {
                message = "Dispensing money......";
                balance = balance - withdraw_amount;

            }

        }

        public void transfer_money(double amount, int bank_number, string bank_type)
        {
            double maximum_amount = 5000;
            double transfer_amount = amount;
            string message;
            if (amount > balance)
            {
                message = "Insufficient balance";
            }
            else if (transfer_amount > maximum_amount)
            {
                message = "You are not allowed to transfer over RM" + maximum_amount;
            }
            else
            {
                message = "Transfering money......";
                balance = balance - transfer_amount;

            }

        }

        public void Check_balance()
        {
            string message = "Your balance : RM" + balance;
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public void change_pin(int new_pin)
        {
            pin_number = new_pin;
        }
    }
}
