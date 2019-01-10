using System;

namespace lab2_unittesting
{
    public class Program // added public so can call it in the test environment
    {
        public static double balance = 5000.00;
        static void Main(string[] args)
        {
            //this is where the switch will go
            ReturnsBalance(balance);
        }

        public static double ReturnsBalance(double balance)
        {
        return balance;
        }

    }
}
