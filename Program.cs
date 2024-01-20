using System;

class Vehicle  // base class (parent) 
{
    public string Brand = "Ford";  // Vehicle field
    public static void Honk()      // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string ModelName = "Mustang";  // Car field
    public ConsoleColor MainColor = ConsoleColor.Red; // Car color

    public ConsoleColor GetAdjustedColor()
    {
        if (MainColor == ConsoleColor.Green)
        {
            return ConsoleColor.DarkGreen;
        }

        return MainColor;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        ConsoleColor vc = myCar.GetAdjustedColor();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{myCar.Brand} {myCar.ModelName} (Color: ");
        Console.ForegroundColor = vc;
        Console.Write($"{vc}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($")");
        Vehicle.Honk();
    }
}
