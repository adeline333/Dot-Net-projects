using System;
class UnitConverter
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the units converter");
            Console.WriteLine("Please select from one of the following options");
            Console.WriteLine("1.Miles to Kilometers ");
            Console.WriteLine("2. Pounds to kilograms"); 
            Console.WriteLine("3.Fahrenheit to Celsius");
            String input = Console.ReadLine();

            //valiadate user input
            if (input == "1")
            {
                MilesToKilometers();
            }
            else if (input == "2")
            {
                PoundsToKilograms();
            }
            else if (input== "3" )
            {
                FahrenheitToCelcius();
            }
            else {
                Console.WriteLine("Invalid input");

                    }


        }
    }


}