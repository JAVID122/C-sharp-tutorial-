using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{

    internal class Overload
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
        public void Test( int i)
        {
            Console.WriteLine("number Method");
        }
        public void Test(string s)
        {
            Console.WriteLine("sting Method");
        }

        public void Test(string s ,int i)
        {
            Console.WriteLine("sting and number  is printed");
        }


        public void Test(int i, string s)
        {
            Console.WriteLine("number and sting is printed");
        }
        //over loads meand differnt methods with differnt parameters or order of parameters
        //Type or number or order of input will chanage result in overloading
        // suppose string class has many methods and they will beahve according to input
        //

        //string s ="Hello world"
        //    s.IndexOf('o;)    4 is returned 

        //    s.Indexof('o', 5); 7 is returned

       // so  n number of overloads are there for Indexof() method

        
        static void Main()
        {
            // Method OverRiding: it is an approach of re-implementing a parent classes method under the child class with the same signature
            Overload o = new Overload();
            //o.Test();
            //o.Test(5);
            //o.Test("Hello");
            //o.Test("Hello", 5);
            o.Test(5, "Hello");
            Console.ReadLine();


            // Overloading: In this case we define multiple methods with the same name by changing their parameters
            // this can be performed either within a class as well as between parent child  classes also.
            // while overloading a parent classes method under the child class, child class does not require to take any permission  from the parent class.
            // overloading is all about defining multiple behaviours to a method name by changing its parameters

            // For example: 
            //class1
            //    show()
            //    show(int  i)
            //    Test()

            //class2:class1
            //    show(string i)
            //    Test()

            // Overriding: In this case we define multiple methods with the same name and same parameters
            // this can be performed only between parent child  classes  never  be performed with in the same classes
            // while overriding a parent classes method under the child class, child class requires to take permission  from the parent class by using 'virtual' keyword in parent class method and 'override' keyword in child class method.
            //Note :If we want to override a parents method under child class first that method should be declared by using modifier in parent class
            // By using 'virtual' keyword in parent class method and 'override' keyword in child class method. it is giving permission to child class to override the parent class method
            //for example 
            //    class1
            //    public virtual void Show()


            //class2:class1
            //    public override void Show()

            // overriding is all about redefining the behaviour of a parent classes method under the child class by keeping same signature
            //for example 
            //    class1 
            //    Test()
            //    Test()   // this is not possible in Overriding 
            //    class2:class1
            //    Test()


        }
    }
}
