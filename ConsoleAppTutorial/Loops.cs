using System;

public class Loops
{
    public static void ForLoop()
    {
        int myInt = 0;

        while (myInt < 10)
        {
            Console.Write("{0} ", myInt);
            myInt++;
        }
        Console.WriteLine();
    }

    public static void DoWhile()
    {
        string myChoice;

        do
        {
            // Print menu
            Console.WriteLine("My Address Book\n");
            Console.WriteLine("A - Add new address");
            Console.WriteLine("D - Delete address");
            Console.WriteLine("M - Modify address");
            Console.WriteLine("V - View address");
            Console.WriteLine("Q - Quit\n");

            myChoice = Console.ReadLine();

            switch (myChoice)
            {
                case "A":
                case "a":
                    Console.WriteLine("You've selected to add an address");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("you've selected to delete an address");
                    break;
                case "M":
                case "m":
                    Console.WriteLine("You've selected to modify an address");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("You've selected to view an address");
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Logging off...");
                    break;
                default:
                    Console.WriteLine("{0} is an invalid choice", myChoice);
                    break;
            }

            //Pause to allow user to see results
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        } while (myChoice != "Q" && myChoice != "q");
    }

    public static void ForEach()
    {
        string[] names = { "Kevin", "Joe", "Danny", "Matt", "Robert" };

        foreach(string person in names)
        {
            Console.WriteLine("{0} ", person);
        }

    }

	public static void Main()
	{
        string userSelection;
        Console.WriteLine("Please make a selection from the following: ");
        Console.WriteLine("1 - Execute While Loop");
        Console.WriteLine("2 - Execute Do While Loop");
        Console.WriteLine("3 - Execute For Each Loop");
        userSelection = Console.ReadLine();
        switch (userSelection)
        {
            case "1":
                ForLoop();
                break;

            case "2":
                DoWhile();
                break;

            case "3":
                ForEach();
                break;

            default:
                Console.WriteLine("Invalid Selection");
                break;
        }
	}
}
