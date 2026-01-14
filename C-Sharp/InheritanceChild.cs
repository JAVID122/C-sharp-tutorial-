using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{


    // Important points about inheritance in C#:
    // 1.Parent classes constructor must be accessible to the child class. otherwise inheritance will not be possible
    // why Parent class constructor should be accessible to child class?
    // Ans: if it accessible then only its members are initialized and will get consumed by child class
    // 2. we can initialize a parent classess variable by using the child class instance to make it as a reference
    // 3. Every class that is defined by us  or pre-defined in the libraries of the language has a default parent  class i,e Object class of system  name space  so we can call members of Object class
    // 
    //


    


    //child class will implecitely called the parent class contructor
    // 

    internal class InheritanceChild: Inheritance
    {
        public InheritanceChild( int a):base( a)
        {
            Console.WriteLine("Child class default constructor gets executed");
        }



// For here we will remember an important point that is execution will always start
// from parent class constructor the child class contructor now we can use this value in both parent and child
        //public void Test3()
        //{
        //    Console.WriteLine("Test 3 gets printed");
        //}
        static void Main()
        {
            InheritanceChild t = new InheritanceChild(5);
            //    t.Test1(); // Protected Method - Accessible (because of inheritance)
            //    t.Test2(); // Public Method - Accessible
            //    t.Test3(); // Test 3 gets printed

            //  if we want to pass value dynamically then declare parameter type in the constructor of child class
            // 

            //    Console.ReadLine();


            // Entity: it is a living or non-living object associated with a set of attributes.
            // Example: Student, Employee, Car, Bike, House, etc.

            // when we develop an application the process will be following:
            // 1. Identify the entities required for the application
        }
    }
}
