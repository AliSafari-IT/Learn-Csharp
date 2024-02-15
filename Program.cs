﻿// Demonstrate Abstract Class

// This is an abstract class. 
// You cannot create instances of an abstract class. 
// It serves as a blueprint for other classes.
abstract class AnimalAbstraction
{
    public abstract void AnimalSound();

    public static void Sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class CatAbstraction : AnimalAbstraction
{
    public override void AnimalSound()
    {
        Console.WriteLine("The Cat says: meow mew!");
    }
}

class Program
{
    static void Main()
    {
        CatAbstraction myCat = new();
        myCat.AnimalSound();
        AnimalAbstraction.Sleep();

        MyStack stack = new MyStack(10);  // Using the array-based option
        stack.Push(5);
        stack.Push(10);

        ListStack<int> listStack = new();  // Using the list-based option
        listStack.Push(5);
        listStack.Push(10);
        
    }
}