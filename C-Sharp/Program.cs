// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Constructors

// A constructor is a special method that is called when an object of a class is created. It is used to initialize the object's properties and allocate resources.
//using System;
//class Car
//{
//    // Properties
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }
//    // Method to display car details
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Car Make: {Make}, Model: {Model}, Year: {Year}");
//    }
//}
//class Program
//{
//static void Main(string[] args)
//{
// Creating an object of the Car class using the constructor
//Car myCar = new Car();
// Displaying car details
//myCar.DisplayInfo();
//}
//}
// From the above code, we can see that the Car class has a constructor that initializes the Make, Model, and Year properties when a new Car object is created. The DisplayInfo method is used to print the car's details to the console.


// types of constructors 
// 1. Default Constructor:
// Parameterized Constructor
// Copy Constructor
// Static Constructor

// 1. Default Constructor: if a constructor method doest not take  any parameters, it is called a default constructor.
// Example:Above code is an example of a default constructor. these construtors are automatically provided by the compiler if no constructors are defined in the class.
// thsese constructors can be defined by a progrmmer explicitly or else will be default implicitely provided there if there is no explicit constructor under the class.


// 2. Parameterized Constructor: A parameterized constructor is a constructor that takes parameters to initialize an object's properties with specific values when the object is created. This  constructors can be defined by the programmers only but never can be defined implicitely.

//3  Copy Constructor: if we want to create multiple instances with the same values then we use these copy constructors , in a copy constructor the constructor takes the same class as a parameter to it

// Static Constructor: if a constructor is explicitly declared by using static modifier we call that as static Constructor.  All the constructors we have defined till now are non- static or instance constructors.

// even if we define a static constructor when we complile a Implecit contructor is also creATED


//. IF A CLASS CONTAINS ANY static variables then only implecit static constructors will be present  or else we need to define them
// explicitely whereas non-static constructors will be implecitely in every class


//  static constructors are responsible in initializing static variaables
// and these constructotrs  are never called explicitly they are implicitly called
// // and more over these constructors are first to execute  under any class