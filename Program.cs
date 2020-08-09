using System;


/*
**An interface is like a contract. In the human world, the contract between the two or more 
**humans binds them to act as per the contract. In the same way, the interface includes the 
**declaration of one or more functionalities. Entities that implement the interface must define 
**functionalities declared in the interface. In C#, a class or a struct can implement one or more interfaces.

**In C#, an interface can be defined using the interface keyword. Interfaces can contain methods, 
**properties, indexers, and events as members.
*/

namespace ConsoleApp
{
    
//Interface
interface IAnimal 
{
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class ConsoleApp 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}

}