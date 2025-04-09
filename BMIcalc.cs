using System;

namespace BMIcalc
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("welcome to the BMI calculator");
            double weight = GetWeight();
            double height = GetHeight();
            double BMI = calculateBMI(weight, heigh);
            Console.WriteLine("your final weight is" + Math.Round(BMI, 2));


        }
        static double getWeight()
        {
            Console.writeLine("enter your weight in pounds");
            double weight=double.Parse(Console.ReadLine());
            return weight;

        }

        static double GetHeight()
        {
            Console.WriteLine("enter your height in feet and inches (ex:5'8\"): ");
            String input=Console.ReadLine();
            String[] split = input.Split("'");
            double feet = double.Parse(split[0]);
            double inches= Double.Parse(split[1]).Trim('"');
            double height = (feet * 12) + inches;
            return height;


        }
        static double calculateBMI(double weight, double height)
        {
            //convert inches to meters
            double meterHeight = height * 0.0254;
            //convert our weight into kilograms
            double kilogramWeight = weight * 0.0453592;
            double bmi = kilogramWeight / (meterHeight * meterHeight);
            return bmi;
        }

    }
}

