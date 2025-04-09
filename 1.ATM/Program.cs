using System;
using System.Collections.Generic;
using System.Linq;

public class CardHolder
{
    private string cardNum;
    private int pin;
    private string firstName;
    private string lastName;
    private double balance;

    public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string GetCardNum() => cardNum;
    public int GetPin() => pin;
    public string GetFirstName() => firstName;
    public string GetLastName() => lastName;
    public double GetBalance() => balance;

    public void SetCardNum(string newCardNum) => cardNum = newCardNum;
    public void SetPin(int newPin) => pin = newPin;
    public void SetFirstName(string newFirstName) => firstName = newFirstName;
    public void SetLastName(string newLastName) => lastName = newLastName;
    public void SetBalance(double newBalance) => balance = newBalance;

    public static void Main(string[] args)
    {
        void PrintOptions()
        {
            Console.WriteLine("Please choose from one of the following options:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine($"Thank you for your $$ . Your new balance is: {currentUser.GetBalance()}");
        }

        void Withdrawal(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());

            // Check if the user has enough money
            if (currentUser.GetBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                double newBalance = currentUser.GetBalance() - withdrawal;
                currentUser.SetBalance(newBalance);
                Console.WriteLine("You're good to go, thank you!");
            }
        }

        void ShowBalance(CardHolder currentUser)
        {
            Console.WriteLine($"Current Balance: {currentUser.GetBalance()}");
        }

        List<CardHolder> cardHolders = new List<CardHolder>
        {
            new CardHolder("7868275678262", 767, "Karoli", "Isaac", 50000),
              new CardHolder("7868275678263", 767, "Karoli", "Isaac", 50000),
                new CardHolder("7868275678264", 767, "Karoli", "Isaac", 50000)
        };

        // Prompt user
        Console.WriteLine("Welcome to Simple ATM");
        Console.WriteLine("Please insert your debit card:");
        string cardNum;
        CardHolder currentUser;
        Console.WriteLine("Please enter your card number.");


        while (true)
        {
            Console.WriteLine("Enter a numeric card number:");
            cardNum = Console.ReadLine();

            // Check if the input is numeric
            if (long.TryParse(cardNum, out _)) // Use long.TryParse to check if it's a valid CARD number
            {
                // Search the cardHolders list for the entered card number
                currentUser = cardHolders.FirstOrDefault(a => a.GetCardNum() == cardNum);

                if (currentUser != null)
                {
                    Console.WriteLine("Card number validated successfully.");
                    break; // Exit the loop if a match is found
                }
                else
                {
                    Console.WriteLine("Incorrect card number. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric card number.");
            }
        }




        int userPin;
        Console.WriteLine("Please enter your PIN:");

        while (true)
        {
            Console.Write("Enter a numeric PIN: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userPin))
            {
                if (userPin == currentUser.GetPin()) // Check if it matches the current user's PIN
                {
                    break; // Exit loop if PIN is correct
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric PIN.");
            }
        }


        Console.WriteLine($"Welcome {currentUser.GetFirstName()}");

        int option = 0;
        do
        {
            PrintOptions();
            Console.WriteLine("Please select an option:");

            string input = Console.ReadLine();

            // Use int.TryParse to check if the input is a valid integer
            if (int.TryParse(input, out option))
            {
                // Check the valid options
                if (option == 1)
                {
                    Deposit(currentUser);
                }
                else if (option == 2)
                {
                    Withdrawal(currentUser);
                }
                else if (option == 3)
                {
                    ShowBalance(currentUser);
                }
                else if (option == 4)
                {
                    break; // Exit the loop if user selects 4
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (option != 4);

        Console.WriteLine("Thank you! Have a nice day :)");

    }
}
