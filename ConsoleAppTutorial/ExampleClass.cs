using System;

// Helper class
class OutputClass
{
    string myString;

    // Constructor 
    public OutputClass(string inputString)
    {
        myString = inputString;
    }

    // Instance method
    public void printString()
    {
        Console.WriteLine("{0}", myString);
    }

    public static void staticPrinter()
    {
        Console.WriteLine("This is the static printer!");
    }

    // Destructor
    ~OutputClass()
    {

    }
}

// Program start class
class ExampleClass
{
    // Main begins program execution
    public static void Main()
    {
        OutputClass outC1 = new OutputClass("This is printed by the output class.");

        // Call output class' method
        outC1.printString();
        OutputClass.staticPrinter();
    }
}