// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

// Interface definition
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

// Base class Animal
public class Animal
{
    // Virtual method that can be overridden in derived classes
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

// Derived class Dog that overrides the Speak method
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

// Derived class Cat that overrides the Speak method
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

// Shape class that implements IShape interface
public class Circle : IShape
{
    public double Radius { get; set; }

    // Constructor to initialize Circle's radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Calculate area of the circle
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Calculate perimeter (circumference) of the circle
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Rectangle class that implements IShape interface
public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor to initialize Rectangle's length and width
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Calculate area of the rectangle
    public double CalculateArea()
    {
        return Length * Width;
    }

    // Calculate perimeter of the rectangle
    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

// Singleton class with a private constructor
public class Singleton
{
    private static Singleton _instance;

    // Private constructor
    private Singleton() { }

    // Public method to get the instance of the Singleton class
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testing the Animal and its derived classes (Polymorphism)
        Animal myAnimal = new Animal();
        myAnimal.Speak();  // Output: Animal speaks

        Animal myDog = new Dog();
        myDog.Speak();  // Output: Dog barks

        Animal myCat = new Cat();
        myCat.Speak();  // Output: Cat meows

        // Testing the IShape interface implementation
        IShape myCircle = new Circle(5);
        Console.WriteLine($"Circle Area: {myCircle.CalculateArea()}");
        Console.WriteLine($"Circle Perimeter: {myCircle.CalculatePerimeter()}");

        IShape myRectangle = new Rectangle(4, 6);
        Console.WriteLine($"Rectangle Area: {myRectangle.CalculateArea()}");
        Console.WriteLine($"Rectangle Perimeter: {myRectangle.CalculatePerimeter()}");

        // Testing Singleton pattern
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();
        Console.WriteLine($"Are both Singleton instances the same? {singleton1 == singleton2}"); // Output: True
    }
}
