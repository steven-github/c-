using System;

namespace Lab03.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Credit credit = new Credit()
            {
                Amount = 0
            };

            Debit debit = new Debit()
            {
                Amount = 10000
            };

            int opt1;
            do
            {
                opt1 = DisplayMenu();
                switch (opt1.ToString())
                {
                    case "1":
                        System.Console.Write("\nAmount: $");
                        decimal amount = decimal.Parse(System.Console.ReadLine());
                        int opt2;
                        do
                        {
                            opt2 = DisplaySubMenu();
                            switch (opt2.ToString())
                            {
                                case "1":
                                    System.Console.WriteLine(debit.Sell(amount));
                                    break;
                                case "2":
                                    System.Console.WriteLine(credit.Sell(amount));
                                    break;
                            }
                        } while (opt2 != 1 && opt2 != 2);
                        break;
                }
            } while (opt1 != 2);

        }

        public static int DisplayMenu()
        {
            System.Console.Write("\n1.Sell \n2.Exit \nOption: ");
            return int.Parse(System.Console.ReadLine());
        }

        public static int DisplaySubMenu()
        {
            System.Console.Write("\nPay using: \n1.Debit account \n2.Credit account \nOption: ");
            return int.Parse(System.Console.ReadLine());
        }

    }
}
