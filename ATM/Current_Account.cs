using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Current_Account : Account
    {

        public override void transfer_money(double amount, int bank_number, string bank_type)
        { 
            double transfer_amount = amount;
            string message;
            if (amount > getBalance())
            {
                message = "Insufficient balance";
            }else
            {
                message = "Transfering money......";
                setBalance(getBalance() - transfer_amount);

            }

        }




    }
}
