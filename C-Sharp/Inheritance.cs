using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Inheritance
    {
        //public int variable1;
        //public int variable2;


        public Inheritance(int i) {

            //Console.WriteLine("Parent class default constructor gets executed ");

            Console.WriteLine("Parent class default constructor gets executed " + i);

            // default behaviour of constructor is private so if we want this constructor to be exceeible to child class put public modifier before it
        }

        protected void Test1()
        {
            Console.WriteLine("Test 1 gets printed");
        }

        public void Test2()
        {
            Console.WriteLine("Test 2 gets printed");
        }
        //Inheritance obj1 = new Inheritance(10, 20);
        // Inheritance :
        // Its a machanism of consuming the members of one class in another class by establishing parent child relationship clasees
        // in inheritance child class can consume members of its parent class as if it is the owner of those members(except private members of parent).

        // Important points about inheritance in C#:
        // Parent classes constructor must be accessible to the child class. otherwise inheritance will not be possible

        //

        //static void Main()
        //{
            //Inheritance first;

            //InheritanceChild second = new InheritanceChild();

            //    first = second;// first  is a reference of the class Inheritance which is initialized by using the instance of the child class InheritanceChild
            //reference of a class will not have any memomry allocation  they will be consuming the memory of the instance that is assigned to initailize them .
            //but still we can not call child classes by this reference
            //

            // we can initialize a parent classess variable by using the child class instance to make it as a reference

            //first.Test1();
            //first.Test2();    

            //Inheritance obj = new Inheritance();
            //obj.GetHashCode();

            //obj.ToString();
            //obj.Equals(obj);
            //obj.GetHashCode();
            //obj.GetType();
            // above are the members of Object class and are acessible to every class we define
            // every class whether we create or library class is by default inherited from Object class of system namespace
            // so we can call members of Object class

            // Types of Inheritance:
            // 1. Single Inheritance : when a child class inherits from a single parent class
            // 2. Multilevel Inheritance : when a class is derived from a class which is also derived from another class
            // 3. Hierarchical Inheritance : when multiple classes are derived from a single parent class
            // 4. Hybrid Inheritance : combination of two or more types of inheritance
            // Note: C# does not support multiple inheritance (a class cannot inherit from more than one class) to avoid ambiguity and complexity



            // or simply we can say there are two types of inheritance
            //Single inheritance and Multiple inheritance

            // if at ll a class has 1 immediate parent class to it we call it as single inheritance and if it has more than 1 immediate parent class to it we call it as multiple inheritance


            // in C# multiple inheritance is not supported directly but we can achieve multiple inheritance by using interfaces:

            //pont 6 to remember about inheritance in C#:
            // In the first point we learnt when ever child class instance is created child class constructor will implicitly call its parent classes constructor but only if the constructor is parameter less, where as if the constructor
            // of the parent class is parameterized child class constructor can not implicitly call its parent constructor, 
            // so to overcome the problem it is the responsiblity of the programmer to explicitly call parent classes contructor from child class constructor and pass values to those parameters . 
            // to call parent class constructor from child class constructor we have to use base keyword followed by paranthesis containing parameters to be passed to parent class constructor we need to use the "BASE" keyword









        //}

    }
}
