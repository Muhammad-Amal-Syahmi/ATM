using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Saving_Account : Account
    {
        public override void withdraw(double amount)
        {
            double maximum_amount = 5000;
            double withdraw_amount = amount;
            string message;
            if (amount > getBalance())
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
                setBalance(getBalance() - withdraw_amount);
                
            }

        }

        public override void transfer_money(double amount, int bank_number, string bank_type)
        {
            double maximum_amount = 5000;
            double transfer_amount = amount;
            string message;
            if (amount > getBalance())
            {
                message = "Insufficient balance";
            }
            else if(transfer_amount > maximum_amount)
            {
                message = "You are not allowed to transfer over RM" + maximum_amount;
            }
            else
            {
                message = "Transfering money......";
                setBalance(getBalance() - transfer_amount);

            }

        }
     



    }
}
