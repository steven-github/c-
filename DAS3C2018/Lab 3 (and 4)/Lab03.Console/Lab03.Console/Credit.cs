using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03.Console
{
    class Credit:Account
    {

        public override string Sell(decimal amount)
        {
            string paymentStatus = " Success!";
            decimal limit = -8000;
            decimal oldBalance = Amount;
            decimal newBalance = Amount - amount;

            StringBuilder sb = new StringBuilder();
            sb.Append(base.Sell(amount));

            if (newBalance < limit)
            {
                paymentStatus = " Failed... Your credit account limit is -$8000";
                sb.Append(paymentStatus + "\nCurrent balance: $" + oldBalance + "\nAvailable funds: $" + (limit + (-oldBalance + amount)));
            }
            else
            {
                Amount = newBalance;
                sb.Append(paymentStatus + "\nOld balance: $" + oldBalance + "\nPayment: $" + amount);
                sb.Append("\nNew balance: $" + Amount);
            }

            return sb.ToString();

            //Amount -= amount;
            //return base.Sell(amount) + " credit account... Bank balance: $" + Amount;
        }
    }
}
