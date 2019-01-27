using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03.Console
{
    class Debit:Account
    {
        public override string Sell(decimal amount)
        {
            string paymentStatus = " Success!";
            decimal oldBalance = Amount;
            decimal newBalance = Amount - amount;

            StringBuilder sb = new StringBuilder();
            sb.Append(base.Sell(amount));

            if (newBalance < 0)
            {
                paymentStatus = " Failed... Insufficient funds in your debit account!";
                sb.Append(paymentStatus + "\nAvailable funds: $" + oldBalance + "\nYou're trying to pay: $" + amount);
            } else {
                Amount = newBalance;
                sb.Append(paymentStatus + "\nOld balance: $" + oldBalance + "\nPayment: $" + amount);
                sb.Append("\nNew balance: $" + Amount);
            }

            return sb.ToString();

            //Amount -= amount;
            //return base.Sell(amount) + " debit account... please wait...\nOld balance: ${Amount} \nNew balance: $" + Amount;
        }
    }
}
