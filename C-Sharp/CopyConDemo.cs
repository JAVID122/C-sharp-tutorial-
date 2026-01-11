//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Sharp
//{
//     class CopyConDemo
//    {
//        int x;
//        public CopyConDemo(int i)  // Parameterised constructot
//        {
//            x = i;
//        }
//        public CopyConDemo(CopyConDemo obj)  // Copy Constructor
//        {
//            x = obj.x;

//        }
//        // CopyConDemo is new data type now like int above

//        // we can define multiple constructors in a class
//        public void Display()
//        {
//            Console.WriteLine($"value of x is : {x}");
//        }


//        static void Main()
//        {
//            CopyConDemo cd1 = new CopyConDemo(10);
//             cd1.Display();
//            //CopyConDemo cd2 = new CopyConDemo(10);
//            CopyConDemo cd2 = new CopyConDemo(cd1);
//            CopyConDemo cd3 = new CopyConDemo(cd1);
//            CopyConDemo cd4 = new CopyConDemo(cd1);
//            // memory will be seperate for each instance but value will be same now
//            cd2.Display();
//            cd2.Display();
//            cd3.Display();
//            cd4.Display();

//            Console.ReadLine();
//        }

//    }

//    }

// the program has got problem what if
// tommorwo we want to create 100 of similar objets do we create them manually or simply use copy constructor to create them 