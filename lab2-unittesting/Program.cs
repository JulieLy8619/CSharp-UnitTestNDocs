using System;

namespace lab2_unittesting
{
    public class Program // added public so can call it in the test environment
    {
        public static double balance = 5000.00;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Special Unicorn ATM");
            bool running = true;
            do
            {
                MenuSelection(balance);
            } while (running); //I am ok with that I don't reset to false at any point becasuse exit will exit the program
            Console.ReadLine(); //so it doesn't auto exit
        }

        public static double ReturnsBalance(double balance)
        {
            Console.WriteLine($"Your balance is {balance}");
        return balance;
        }

        public static void MenuSelection(double balance)
        {
            Console.WriteLine("Make a selection");
            Console.WriteLine("1: Check your Balance");
            Console.WriteLine("2: Make a Deposit");
            Console.WriteLine("3: Make a Withdrawl");
            Console.WriteLine("4: Exit");
            string userChoice = Console.ReadLine();
            int userChoiceInt = Convert.ToInt32(userChoice);
            switch (userChoiceInt)
            {
                case 1:
                    Console.WriteLine("in switch 1");
                    //call balance function
                    break;
                case 2:
                    Console.WriteLine("in switch 2");
                    //call deposit function
                    break;
                case 3:
                    Console.WriteLine("in switch 3");
                    //call withdrawl function
                    break;
                default:
                    //Console.WriteLine("in switch 4");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }


    }
}
