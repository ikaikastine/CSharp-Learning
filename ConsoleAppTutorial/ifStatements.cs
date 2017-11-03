using System;

public class IfSelect
{
    public static void GreaterThanZero(int val)
    {
        // Less than 25
        if (val <= 25)
        {
            Console.WriteLine("Your number {0} is less than 25", val);
        }
        else if (25 < val || val < 50)
        {
            Console.WriteLine("Your number {0} is greater than 25 and less than 50", val);
        }
        else
        {
            Console.WriteLine("Your number {0} is large.", val);
        }
    }

    public static void LessThanZero(int val) => Console.WriteLine("Your number {0} is less than zero.", val);

    public static void Main()
	{
        string myInput;
        int myInt;

        Console.Write("Please enter a number: ");
        myInput = Console.ReadLine();
        myInt = Int32.Parse(myInput);

        if (myInt > 0)
        {
            GreaterThanZero(myInt);
        }
        else if (myInt < 0)
        {
            LessThanZero(myInt);
        }
	}
}
