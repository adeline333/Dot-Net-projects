using System;

namespace FarmingCompanyProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Farming Company Progress Tracker!");

           
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter the crop yield (in tons): ");
            double cropYield = double.Parse(Console.ReadLine());

            Console.Write("Enter the price per ton (in your currency): ");
            double pricePerTon = double.Parse(Console.ReadLine());

            //labor detais
            Console.Write("Enter the number of workers hired: ");
            int numberOfWorkers = int.Parse(Console.ReadLine());

            Console.Write("Enter the daily wage per worker (in your currency): ");
            double dailyWage = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of days workers were hired for: ");
            int numberOfDays = int.Parse(Console.ReadLine());

                        double laborCosts = numberOfWorkers * dailyWage * numberOfDays;  
            double totalEarnings = cropYield * pricePerTon;                 
            double netIncome = totalEarnings - laborCosts;                 

                    
            Console.WriteLine($"\n--- Farming Progress Report ({year}) ---");
            Console.WriteLine($"Crop Yield: {cropYield} tons");
            Console.WriteLine($"Price per Ton: {pricePerTon}");
            Console.WriteLine($"Labor Costs: {laborCosts} (calculated for {numberOfWorkers} workers over {numberOfDays} days)");
            Console.WriteLine($"Total Earnings: {totalEarnings}");


            if (netIncome > 0)
            {
                Console.WriteLine($"Net Income (Profit): {netIncome}");
                Console.WriteLine("Congratulations! You've made a profit this year.");
            }
            else if (netIncome < 0)
            {
                Console.WriteLine($"Net Income (Loss): -{Math.Abs(netIncome)}");
                Console.WriteLine("Unfortunately, this year you made a loss. Better luck next time.");
            }
            else
            {
                Console.WriteLine("Net Income: $0.00 (No profit, no loss)");
                Console.WriteLine("You broke even this year.");
            }

            Console.WriteLine("\nThank you for using the Farming Company Progress Tracker!");
        }
        }
        }