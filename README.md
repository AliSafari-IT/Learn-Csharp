# Basic OOP concept

This code is a neat demonstration of basic OOP principles in action, like different gears coming together to drive a well-functioning machine!

## Key Concepts Illustrated

- **Inheritance**: `Car` inherits from `Vehicle`, so it has access to the `Vehicle`'s members (`Brand` and `Honk`), plus its own (`ModelName`, `MainColor`, `GetAdjustedColor`).

- **Static Method**: `Honk` is a static method, illustrating how such methods are called on the class itself rather than on instances.

- **Instance Method and Fields**: `GetAdjustedColor` is an instance method, working with instance fields like `MainColor`.

- **Object Instantiation**: `Car myCar = new Car();` shows how to create an instance of a class.

- **Method Calling**: The way `GetAdjustedColor` and `Honk` are called demonstrates calling instance and static methods, respectively.

- **Console Operations**: The code shows how to write to the console and change the console's foreground color.


```csharp
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

```

> ***Output***
![ConsoleColor](img/ConsoleColor.png)
