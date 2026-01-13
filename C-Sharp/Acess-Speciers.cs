using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp { 


    // Access Specifiers
    //It is a special kind of modifers using which we can define the scope of a type and its members
    // There are 5 types of access specifiers in C#
    // 1. Public
    // 2. Private
    // 3. Protected
    // 4. Internal
    // 5. Protected Internal
    // By default, all the members of a class are private
    // Public: The members declared as public are accessible from anywhere in the application
    // Private: The members declared as private are accessible only within the class
    // Protected: The members declared as protected are accessible within the class and its derived classes
    // Internal: The members declared as internal are accessible only within the same assembly
    // Protected Internal: The members declared as protected internal are accessible within the same assembly and from derived classes
    // Example:
    // public class MyClass
    // {
    //     public int publicVar;
    //     private int privateVar;
    //     protected int protectedVar;
    //     internal int internalVar;
    //     protected internal int protectedInternalVar;
    // }
    // In the above example, publicVar can be accessed from anywhere, privateVar can be accessed only within MyClass, protectedVar can be accessed within MyClass and its derived classes, internalVar can be accessed only within the same assembly, and protectedInternalVar can be accessed within the same assembly and from derived classes.
    // Access specifiers help in encapsulating the data and controlling the visibility of class members, thereby enhancing security and maintainability of the code.
    //}
    //
    internal class Acess_Speciers
{
    private void Test1()
    {
        Console.WriteLine("Private Method");
    }
    public void Test2()
    {
        Console.WriteLine("Public Method");

    }

        internal void Test3() { 
         Console.WriteLine("Internal Method");

        }

        protected void Test4()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test5()
        {
            Console.WriteLine("Protected Internal Method");
        }

        //static void Main()
        //{
        //    Acess_Speciers acess_Speciers = new Acess_Speciers();
        //    acess_Speciers.Test1();
        //    acess_Speciers.Test2();
        //    acess_Speciers.Test3();
        //    acess_Speciers.Test4();
        //    acess_Speciers.Test5();



        //}




        }
}
