using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public interface IAccount
    {
        int pin_number { get; set; }
        double balance { get; set; }
        void Check_balance();
        void withdraw(double amount);
        void deposit(double amount);
        void transfer_money(double amount, int bank_number, string bank_type);
        void change_pin(int new_pin);
    }
}
