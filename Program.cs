using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 1

            int max, min, num;
            min = 0;

            Console.WriteLine("Please enter a minimum value");

            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Invalid input. Please enter an integer");
            }

            Console.WriteLine("Please enter a maximum value");

            while (!Int32.TryParse(Console.ReadLine(), out max) || max < min)
            {
                Console.WriteLine("Invalid input. Please enter an integer greater than the minimum you previously entered");
            }


            Console.WriteLine("Please enter a number within your range");

            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            {
                Console.WriteLine("Invalid input. Please enter an integer within the range you gave");

            }

            Console.WriteLine($"Great! Your minimum was {min} your maximum number was {max} and the number you chose was {num}");
            Console.WriteLine();

            // Part 2


            double balance = 150;
            string response;
            double deposit, withdrawal, billsDue;

            bool done = false;
            billsDue = 68.56;



                while (!done)
                {
                    

                    Console.WriteLine();
                    Console.WriteLine("Welcome to Bank Of Blorb!");
                    Console.WriteLine("Please enter one of the following options");
                    Console.WriteLine("1. View Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdrawal");
                    Console.WriteLine("4. Bill payment");
                    Console.WriteLine("5. Quit");

                    response = Console.ReadLine();
                    response = response.ToUpper();



                    if (response == "1" || response == "VIEW BALANCE")
                    {

                        Console.WriteLine("$0.75 transaction fee deducted");
                        balance = balance - 0.75;
                        Console.WriteLine($"Your current balance is {balance.ToString("C")}");
                    }

                    if (response == "2" || response == "DEPOSIT")
                    {

                        Console.WriteLine("$0.75 transaction fee deducted");
                        balance = balance - 0.75;


                        Console.WriteLine($"How much would you like to deposit?");
                        while (!double.TryParse(Console.ReadLine(), out deposit) || deposit < 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive numerical input");
                            balance = balance - 0.75;
                            Console.WriteLine("$0.75 transaction fee deducted");
                            Console.WriteLine("Please try again");

                        }

                        balance = balance - 0.75;
                        balance = balance + deposit;
                        Console.WriteLine($"You deposited {deposit.ToString("C")}. Your new balance is {balance.ToString("C")}");


                    }


                    if (response == "3" || response == "WITHDRAWAL")
                    {
                        Console.WriteLine("$0.75 transaction fee deducted");
                        balance = balance - 0.75;

                        Console.WriteLine("How much would you like to withdrawal?");
                        while (!double.TryParse(Console.ReadLine(), out withdrawal) || withdrawal > balance)
                        {
                            Console.WriteLine("Invalid input! You either entered an invalid input or have insufficient funds to withdrawal");
                            balance = balance - 0.75;
                            Console.WriteLine("$0.75 transaction fee deducted");
                            Console.WriteLine("Please try again");

                        }



                        if (balance >= withdrawal)
                        {

                            balance = balance - withdrawal;
                            Console.WriteLine($"You withdrew {withdrawal.ToString("C")}. Your new balance is {balance.ToString("C")}");



                        }
                    }

                    if (response == "4" || response == "BILL PAYMENT")
                    {
                        Console.WriteLine("$0.75 transaction fee deducted");
                        balance = balance - 0.75;

                        Console.WriteLine($"You currently owe {billsDue.ToString("C")}");
                        Console.WriteLine("Enter any key to pay what you owe");
                        Console.ReadLine();

                        if (balance < billsDue)
                        {
                            Console.WriteLine("Insufficient funds to pay bills");
                        }

                        else if (balance >= billsDue)
                        {
                            balance = balance - billsDue;
                            Console.WriteLine($"You paid off all your bills. Your new balance is {balance.ToString("C")}");
                            billsDue = 0;
                        }

                    }

                    if (response == "5" || response == "QUIT")
                    {
                        Console.WriteLine("Thank you for using Bank of Blorb");
                        done = true;
                    }

                    if (balance < 0.75)
                    {
                        Console.WriteLine("Insufficent funds to pay transaction fee. Unable to use machine");
                        done = true;
                    }

                }
        

        }
        
    }
}
