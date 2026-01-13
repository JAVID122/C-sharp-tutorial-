//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp
//{
//    internal class FirstClass
//    {

        // Class : it is a user defined type
        // Every class is going to be  data type
        // if you are going to consume a class you have to create a copy of that class
        // when you create a copy of class it is called as object or instance of class
        // we can write int =100; as int is just a blue print it does not take any memory
        // similarly string ="hello " ; string is just a blue print it does not take any memory

        // now if we create a copy of int or string then only memory is allocated
        // tO BUILD A house we requirs a plan  so int plan and and int i is constructed
        // so data type is plan of the house and its copy is the house
        // similarly class is a plan of the object and object is the copy of the class
        // so when we create a copy of the class only memory is allocated
        // so class is a user defined data type and object is the instance of the class
        // when we create a copy of the class only then memory is allocated to that object
        // so class is a blue print and object is the real thing
        // so class is a data type and object is the instance of that data type
        // so when we create a copy of the class only then memory is allocated to that object
        // so class is a blue print and object is the real thing
        //int x = 100;
        //static void Main()
        //{
            //int i = 100; // here memory is allocated to i
            //string str = "hello"; // here memory is allocated to str
            //Refrence_Instance_variable obj1 = new Refrence_Instance_variable(); // here memory is allocated to obj1
            //Refrence_Instance_variable obj2 = new Refrence_Instance_variable(); // here memory is allocated to obj2
            //Console.WriteLine(i);
            //Console.WriteLine(str);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            // if we want to consume the instance variable x of the class FirstClass we have to create the instance of the class FirstClass
            //FirstClass obj = new FirstClass();
            //Console.WriteLine(obj.x);

            // now we write 
            // FirstClass obj 
            // this is called the variable of the class " variable of class menas copy of class that is not initailized"
            // if we try to access like this
            // Console.WriteLine(obj.x) that is not possibel as it just the varible of class we can acesss that by instance that is created by using "NEW" key word

            // we can crete the instance of class in below way
            //FirstClass obj;
            //obj = new FirstClass();

            //FirstClass f = new FirstClass(); // f is instance of class

            //FirstClass f; // f is variable of class


            //f = new FirstClass(); // f is instance of class



            // here value of x is not getting printed becoz non static blocks of code is not excessed from static block

            //Console.ReadLine();

            // Variable of a class : a copy of the class that is not initailized

            // Instance of a class : a copy of the class that  is initialized by using the new key word which has its own memory and never shared with another instance;


            // Reference  of the class:  A copy of the class that is initailized by using an existing instance and references of class will not have any memory allocation they will be sharing the same memory of the instance that assigned for initializing the variable. 
            // Reference of a class can be called as a pointer to the instance and every modification  we perform on the members using instance reflects when we access those members thru reference and vive-versa
             
            //FirstClass f1 = new FirstClass();

            //FirstClass f2 = new FirstClass();
            // As many times instances will be created same number of times memory will be created

            //Console.WriteLine(f1.x + " " + f2.x);

            //f1.x = 200;
            //Console.WriteLine(f1.x + " " + f2.x);
            // here f1 and f2 are two different objects and they have their own copy of instance variable x
            // f1 is modified not f2 so they are seperate copies 
            // so instance variables are unique to each object
            // so instance variables are stored in heap memory
            // so each object will have its own copy of instance variables
            // so instance variables are used to store the state of the object
            // so instance variables are used to store the data of the object
            // so instance variables are used to store the properties of the object
            // so instance variables are used to store the attributes of the object
            // so instance variables are used to store the characteristics of the object
            // so instance variables are used to store the features of the object
            // so instance variables are used to store the behavior of the object
            // so instance variables are used to store the identity of the object
            // so instance variables are used to store the state of the object
            // so instance variables are used to store the data of the object
            //f2.x=300;
            // Console.WriteLine(f1.x + " " + f2.x);


            // above examples is proof the memory shared by instance  with another instance
            // changes made on one instance will never reflect on another instance

            //Console.ReadLine();

            // Now let us discuss the refrence of a class
                       //FirstClass f1 = new FirstClass();
            //FirstClass f2;
            //f2 = f1; 
            // here f2 is reference to f1
            // 
            //Console.WriteLine(f1.x + " " + f2.x);
            //f1.x = 500;
            //Console.WriteLine(f1.x + " " + f2.x);
            // here changes made on f1 is reflected on f2 as both are pointing to same memory location
            // so refrence variable is used to refer the same object
            // so refrence variable is used to point to the same object
            // so refrence variable is used to access the same object
            // so refrence variable is used to manipulate the same object
            // so refrence variable is used to modify the same object
            // so refrence variable is used to update the same object
            // so refrence variable is used to delete the same object
            // so refrence variable is used to create the same object
            // so refrence variable is used to destroy the same object
            // so refrence variable is used to manage the same object
            // so refrence variable is used to control the same object
            //Console.ReadLine();




//        }
//    }
//}
