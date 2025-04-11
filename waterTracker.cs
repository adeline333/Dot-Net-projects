using System;

class WaterIntakeTracker
{
    static void Main()
    {
        
        Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter your activity level (1 - Inactive, 2 - Lightly Active, 3 - Very Active): ");
        int activityLevel = int.Parse(Console.ReadLine());

        double waterGoal = weight * 0.033; // 33 milliliters per kg (recommeded by health experts)

        
        if (activityLevel == 2)
        {
            waterGoal += 0.5; // Add 0.5 liters if lightly active
        }
        else if (activityLevel == 3)
        {
            waterGoal += 1; // Add 1 liter if very active
        }

        
        Console.WriteLine($"Your daily water intake goal is {waterGoal:F2} liters."); //water intake rounded to 2 decimal points

        double totalWaterDrunk = 0;

        // Track water intake throughout the day
        while (totalWaterDrunk < waterGoal)
        {
            Console.Write("Enter the amount of water you've drunk today (in liters): ");
            double waterDrunk = double.Parse(Console.ReadLine());
            totalWaterDrunk += waterDrunk;

            // Check if goal has been met
            if (totalWaterDrunk >= waterGoal)
            {
                Console.WriteLine("Congratulations! You've met your daily water intake goal.");
                break;
            }
            else
            {
                Console.WriteLine($"You've drunk {totalWaterDrunk:F2} liters. Keep going!");
            }
        }

        // Display final message
        Console.WriteLine($"You drank {totalWaterDrunk:F2} liters of water today. Keep up the good work!");
    }}