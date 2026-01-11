//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp
//{
//    internal class StaticConDemo
//    {

//      static  StaticConDemo()
//        {
//            Console.WriteLine("static constructor is executed");
//        }

//        static void Main()
//        { 
//            Console.WriteLine( "Main method is executes");

//        }
//    }
//}

// static constructor is executed only once when the class is loaded for the first time .they are first to execute in a class
// static constructors can not be parameterized so overloading static constructors is not possibeble. becoz they are implecitly called so do not get chance to pass a value



// Why constructors are needed in C#?   
// Constructors are special methods in C# that are automatically called when an object of a class is created. They are used to initialize the object's properties and allocate resources.
// Here are some reasons why constructors are needed in C#:
// 1. Initialization: Constructors allow you to set initial values for an object's properties when it is created, hence heplping in creating the instance of the class with a valid state.
// 2. Resource Allocation: Constructors can allocate resources such as memory, file handles, or network connections that the object may need during its lifetime.
// 3. Code Reusability: By using constructors, you can avoid duplicating initialization code in multiple places, making your code more maintainable and reusable.
// Every class in C# has a default constructor provided by the compiler if no constructors are explicitly defined. However, you can define your own constructors to customize the initialization process according to your requirements.
// Constructors can be parameterized, allowing you to pass arguments to them when creating an object, enabling more flexible initialization.

// Overall, constructors are essential for creating well-defined and properly initialized objects in C#.
// Static constructors are used to initialize static members of the class or to perform actions that need to be performed only once, regardless of how many instances of the class are created.
//



// static constructors vs Non-static constructors

