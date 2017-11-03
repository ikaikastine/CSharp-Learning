using System;
using System.Collections.Generic;

public class Shape
{
    // Example members
	public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Virtual Method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle 
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle 
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle 
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}

class ShapesProgram
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Triangle(),
            new Circle()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}