using System.Drawing;

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public static void Honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }

    public static ConsoleColor Color()
    {

        var val = new MainCar().mainColor;
        Console.WriteLine(val);
        if (val == ConsoleColor.Green)
        {
            return ConsoleColor.DarkGreen;
        }

        return val;
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}


class MainCar
{
    public ConsoleColor mainColor = ConsoleColor.Red;

    static void Main()
    {
        Car myCar = new();
        var vc = Vehicle.Color();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{myCar.brand} {myCar.modelName} (Color: ");
        Console.ForegroundColor = vc;
        Console.Write($" {vc}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($")");
        Vehicle.Honk();
    }
}