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

    internal class InheritanceChild : Inheritance
    {
        //public InheritanceChild( int a):base( a)
        //{
        //    Console.WriteLine("Child class default constructor gets executed");
        //}



        // For here we will remember an important point that is execution will always start
        // from parent class constructor the child class contructor now we can use this value in both parent and child
        //public void Test3()
        //{
        //    Console.WriteLine("Test 3 gets printed");
        //}
        static void Main()
        {
            //InheritanceChild t = new InheritanceChild(5);
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
            // E.g: school Applicatio : Student, Teacher, Admin, Principal, Classes, Subjects, Exams, Results etc
            // 2. Identify the attributes of each entity.
            // For example:
            //student:

            // id
            // name
            //Address
            // phone number
            // class
            // Marks
            // Grade
            // Fees

            //Teacher
            // id
            // name
            // Address
            // phone number
            // Designation
            // Salary
            //Qualification
            // Subjects


            // Non Teaching staff
            // id
            // name
            // Address
            // phone number
            // Designation
            // Salary
            //Department
            // Mgrid

            //3 . Above we defined few entities and their attributes and what we see there are many common features
            //among the so in step 3 we will identify the common attributes of each
            //and put them in a hierarchical order and we will put common features in one
            //class and make that as parent class and other classes will be child classes
            //for example
            //   public class Person
            //{
            //    public int id;
            //    public string name, address,

            //         , phoneNumber;


            //}

            //public class Student : Person
            //{
            //    public string className;
            //    public int marks;
            //    public string grade;
            //    public double fees;




            //}

            //4 . After identifying the entities and their attributes we will move to the next step that is defining
            // classes for each entity and defining their members
            // 5. After defining classes we will move to next step that is establishing relationships among the classes
            // for example : inheritance , association , aggregation , composition etc
            // 6. After establishing relationships we will move to next step that is defining methods for each class
            // 7. After defining methods we will move to next step that is creating objects and testing the application
            // 8. After testing the application we will move to next step that is deploying the application
            // 9. After deploying the application we will move to next step that is maintaining the application
            // Give examples for inheritance in real world scenarios
            // Example 1: Vehicle Inheritance
            // Parent Class: Vehicle
            // Child Classes: Car, Bike, Truck
            // Common Attributes: speed, fuelType, capacity
            // Common Methods: start(), stop(), accelerate()
            //class Vehicle
            //{
            //    public int speed;
            //    public string fuelType;
            //    public int capacity;
            //    public void Start()
            //    {
            //        Console.WriteLine("Vehicle started");
            //    }
            //    public void Stop()
            //    {
            //        Console.WriteLine("Vehicle stopped");
            //    }
            //    public void Accelerate()
            //    {
            //        Console.WriteLine("Vehicle accelerated");
            //    }
            //}
            //class Car : Vehicle
            //{
            //    public int numberOfDoors;
            //    public string carType; // Sedan, SUV, etc.
            //}


            // Common Attributes: brand, model, batteryLife

            //class ElectronicDevice
            //{
            //    public string brand;
            //    public string model;
            //    public int batteryLife;
            //}
            //class Smartphone : ElectronicDevice
            //{
            //    public string operatingSystem;
            //    public int cameraResolution;

            //}

        }
    }
}
