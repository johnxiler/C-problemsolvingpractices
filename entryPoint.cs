using System;
/* i used the other exercise scripts to call their methods without using namespaces just their classes and methods.
to run: Type 
dotnet run entryPoint.cs */
namespace entryPoint
{
  public class systemRunner
  {
    public static void Main(string[] args)
    {
      exerciseOne.greetMe.greetNames(); //this will call the class greetMe and its atomic methods inside.
      Console.WriteLine("\nThe Sum of Two numbers is equal to ");
      exerciseTwo.sumOfTwo.sumGy(); //this will call the class sumOfTwo and its atomic methods inside.
      Console.WriteLine("\nThe output is");
      //exerciseThree.divideMe.divider(250 , 300);
      exerciseThree.divideMe.divider();
    }
  }
}

/*
In your code, you are implementing several Object-Oriented Programming (OOP) principles and pillars. The four primary pillars of OOP are:

Encapsulation: Encapsulation is the concept of bundling data (attributes) and the methods (functions) that operate on that data into a single unit known as a class. In your code, both greetMe and sumOfTwo classes encapsulate their respective methods, greetNames and sumGy, providing a clear and self-contained unit for related functionality.

Abstraction: Abstraction is the process of simplifying complex reality by modeling classes based on the essential properties and behaviors. Your code abstracts the concepts of greeting and adding two numbers into separate classes, greetMe and sumOfTwo, which makes the code more understandable and maintainable.

Inheritance: Inheritance is a mechanism where a new class inherits properties and behaviors from an existing class. Your code doesn't explicitly demonstrate inheritance, but it can be extended by creating new classes that inherit from existing ones if needed.

Polymorphism: Polymorphism is the ability of different objects to respond to the same message or method call in a way that is appropriate for their respective types. While your code doesn't demonstrate polymorphism explicitly, it's a concept that allows different classes to have methods with the same name (like greetNames and sumGy) and potentially override them to provide different implementations.

In summary, your code mainly demonstrates encapsulation and abstraction, two essential principles of object-oriented programming. It encapsulates related methods and data into classes and abstracts the concepts of greeting and addition into separate classes, promoting modularity and code organization. If you were to extend your code to include inheritance or use polymorphism in the future, it would also involve those OOP pillars.
*/