// Define a base class `Animal` with a virtual method `animalSound()`.

class Animal  // Base class (parent) 
{
    public virtual void AnimalSound() => Console.WriteLine("The animal makes a sound!");
}

// Define derived classes `Cat` and `Dog` that override the `animalSound()` method.
class Cat : Animal  // Derived class (child) 
{
    public override void AnimalSound() => Console.WriteLine("The cat says: meow miauw!");
}

class Dog : Animal  // Derived class (child) 
{
    public override void AnimalSound() => Console.WriteLine("The dog says:  bow-wow!");
}