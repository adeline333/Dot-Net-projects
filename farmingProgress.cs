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
        }
        }
        }