namespace C_Sharp
{
    internal class ConstructorDemo
    {
        int x;
        static int y;
        static ConstructorDemo()
        {
            Console.WriteLine("static constructor is executed");
        }
        public ConstructorDemo()
        {
            Console.WriteLine("Non-static constructor is executed");
        }
        //Constructors are responsible for initailizing fiels /varaibles of a class ,
        // static constructors are used to initialize static fields of a class or to perform actions that need to be performed only once

        // static constructors are implicitly called when the class is loaded for the first time

        static void Main()
        {
            //ConstructorDemo obj1 = new ConstructorDemo();
            //ConstructorDemo obj2 = new ConstructorDemo();
            // here static constructor is called only once when the class is loaded for the first time
            //static constructors are called  imiplicitly so we do not have chance to pass a value to static constructor
            // static constructors are called imidiately  once the execution of class starts where as non static connstructors executes only after creating the instance of class as well as each and every time the instance of class is cerated as well as evry time we create an instance but static constructors are called only once when the class is loaded for the first time

            // non-static constructor is called each time an object is created


            // In the life cycle of a class ,static constructors  executes one and only one time whereas non-static constructors can execute multiple times depending on how many objects are created from the class
            // non-static constructors executes for zero times of no instance are created 
        }
    }
}
