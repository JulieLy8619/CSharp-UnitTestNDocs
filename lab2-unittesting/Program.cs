using System;

namespace lab2_unittesting
{
    public class Program // added public so can call it in the test environment
    {
        public static double balance = 5000.00;
        static void Main(string[] args)
        {
            //this is where the switch will go
            DisplayMenu(balance);

            ReturnsBalance(balance);
        }

        public static double ReturnsBalance(double balance)
        {
        return balance;
        }

        public static void DisplayMenu(double balance)
        {
            switch (balance)
            {
                case 1:
                    Console.WriteLine("Check your Balance");
                    break;
                case 2:
                    Console.WriteLine("Make a Deposit");
                    break;
                case 3:
                    Console.WriteLine("Make a Withdrawl");
                    break;
                default:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
            }
        }


    }
}
