using System;
using System.Linq;

class MainClass 
{
    public static void Main (string[] args) 
    {
       int i = 0;
       while (i < 10) 
       {
           Console.WriteLine("Enter your height:");
           int height = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter your weight:");
           int weight = Convert.ToInt32(Console.ReadLine());
           double bmi = calculateBMI(height, weight);
           BMIResults(bmi);
           i++;
       }
    }

    public static double calculateBMI (int height, int weight) 
    {
        double bmi = (weight * 703) / (height * height);
        return bmi;
    }

    public static void BMIResults(double bmi) 
    {
        if (bmi >= 30) 
        {
            Console.WriteLine("Obese");
        } else if (bmi >= 25) {
            Console.WriteLine("Overweight");
        } else if (bmi >= 18.5) {
            Console.WriteLine("Normal");
        } else {
            Console.WriteLine("Underweight");
        }
    }
}