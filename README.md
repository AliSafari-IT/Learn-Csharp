## Basic OOP concept

This code is a neat demonstration of basic OOP principles in action, like different gears coming together to drive a well-functioning machine!

### Key Concepts Illustrated

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

## Polymorphism in Action

It's a concept where objects of different classes can be treated as objects of a common superclass. The word itself comes from Greek, meaning "many forms."

In more technical terms, polymorphism allows methods to do different things based on the object they are acting upon. This means you can use a single interface to represent different underlying forms (data types).

### Base Class: Animal

class Animal: This is your base (or parent) class. It represents a generic animal.
public virtual void animalSound(): This method is marked as virtual, which means it can be overridden in derived classes. It provides a default implementation that just prints "The animal makes a sound".

``` csharp
class Animal  // Base class (parent) 
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound!");
    }
}

// Define derived classes `Cat` and `Dog` that override the `animalSound()` method.
class Cat : Animal  // Derived class (child) 
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says: meow miauw!");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says:  bow-wow!");
    }
}

```

The beauty of this code lies in how it demonstrates polymorphism. Both `myCat` and `myDog` are declared as `Animal` type but actually refer to `Cat` and `Dog` objects. Due to method overriding and the way C# handles polymorphism, the correct `animalSound` method is called for each object.

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Create an Animal, a Cat, and a Dog
        Animal myAnimal = new();  
        Animal myCat = new Cat();  
        Animal myDog = new Dog(); 

        // Call the Animal's AnimalSound method on the Animal object
        myAnimal.AnimalSound();
        // Call the Animal's AnimalSound method on the Cat object
        myCat.AnimalSound();
        // Call the Animal's AnimalSound method on the Dog object
        myDog.AnimalSound();
    }
}
```

In summary, this code illustrates how we can use a single interface (`animalSound` method in `Animal`) to achieve different behaviors based on the actual object type (`Cat` or `Dog`). It's like having a universal remote that magically adjusts its controls based on the device it's pointing at!

In essence, polymorphism is about leveraging inheritance to create a more flexible and integrated interface. It's a cornerstone of object-oriented programming, allowing for more dynamic and versatile code.
