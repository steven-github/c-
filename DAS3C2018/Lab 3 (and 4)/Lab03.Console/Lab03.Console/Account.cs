using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03.Console
{
    class Account
    {
        public decimal Amount { get; set; }

        // Virtual method
        public virtual string Sell(decimal amount)
        {
            return "\nPayment";
        }

    }
}
