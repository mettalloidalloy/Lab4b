using System;
					
class MainClass
{
	public static void Main()
	{
		int height;
		int weight;
		int bmi;
		
		Console.WriteLine("Enter your height in inches: ");
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter your weight in pounds: ");
		weight = Convert.ToInt32(Console.ReadLine());

		
		bmi = (weight * 703)/(height * height);

    if (bmi < 18.5)
    {
		Console.WriteLine("Your BMI is {0}. You are underweight.",bmi);
		}

		if (bmi >= 18.5 && bmi <= 24.9 )
		{
		Console.WriteLine("Your BMI is {0}. You are normal weight.",bmi);	
		}	
		
		if (bmi >= 25 && bmi <= 29.9 )
    {
		Console.WriteLine("Your BMI is {0}. You are overweight.",bmi);
    }

    if (bmi > 30)
    {
		Console.WriteLine("Your BMI is {0}. You are Obese.",bmi);
		}
				
			
	}
}