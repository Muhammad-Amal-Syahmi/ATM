using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Current_Account_Interface: IAccount
    {
        public int pin_number { get; set; }
        public double balance { get; set; }

        public void change_pin(int new_pin)
        {
            pin_number = new_pin;
        }

        public void Check_balance()
        {
            string message = "Your balance : RM" + balance;
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }

        public void transfer_money(double amount, int bank_number, string bank_type)
        { 
            double transfer_amount = amount;
            string message;
            if (amount > balance)
            {
                message = "Insufficient balance";
            }else
            {
                message = "Transfering money......";
                balance = balance - transfer_amount;

            }

        }

        public void withdraw(double amount)
        {
            double withdraw_amount = amount;
            string message;

            if (amount > balance)
            {
                message = "Insufficient balance";
            }
            else
            {
                message = "Dispensing money......";
                balance = balance - withdraw_amount;
            }
        }
    }
}
