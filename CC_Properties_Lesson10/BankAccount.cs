using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Properties_Lesson10
{
    internal class BankAccount
    {
        public static int AccountsCounter { get; set; }
        public string bankName;//OLD
        private double balance;
        public User OwnerUser { get; set; }

        public BankAccount()
        {

        }

        public double GetBalance()
        {
            if(DateTime.Now.Hour <= 20)
                return balance;
            return -1;
        }

        //Setter
        public void SetBalance(double newBalance)
        {
            if(newBalance > -100000 && newBalance < 1000000)
                balance = newBalance;
        }
    }
}
