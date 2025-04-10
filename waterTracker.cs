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

    }}