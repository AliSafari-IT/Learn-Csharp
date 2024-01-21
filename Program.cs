
// Cat "implements" the IAnimal interface
internal class Cat : IAnimal 
{
  public void AnimalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The Cat says: meow mew"); 
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Cat myCat = new();  // Create a Cat object
    myCat.AnimalSound();
  }
}