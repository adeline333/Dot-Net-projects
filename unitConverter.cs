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

         static void MilesToKilometers() {
     Console.WriteLine("Please enter the number of miles");
     double miles = double.Parse(Console.ReadLine());
     double kilometers = miles * 1.609344;
     Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers");
         }

 static void PoundsToKilograms()
 {
     Console.WriteLine("Please enter the number of pounds");
     double pounds = double.Parse(Console.ReadLine());
     double kilograms = pounds * 0.45359237;
     Console.WriteLine($"{pounds} pounds is equal to {kilograms} kilograms");
 }

 static void FahrenheitToCelcius()
 {
     Console.WriteLine("Please enter the number of Fahrenheit");
     double Fahrenheit = double.Parse(Console.ReadLine());
     double Celsius = (Fahrenheit - 32) * 5/9;
     Console.WriteLine($"{Fahrenheit} Fahrenhei is equal to {Celsius} Celsius");
 }


}