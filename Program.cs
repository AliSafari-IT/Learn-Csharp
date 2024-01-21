// Demonstrate polymorphism in the `Main` method by creating instances of `Cat` and `Dog`, referenced as `Animal` objects.
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