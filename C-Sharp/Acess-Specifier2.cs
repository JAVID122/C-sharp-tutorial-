using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{

    // classes are only two types Public and internal
    // if we do not specify any access specifier to the class then by default it is internal
    // here we are inheriting the class Acess-Speciers
    // so we can access the protected and protected internal members of the base class
    // derived class can access the protected and protected internal members of the base class
    // if we try to access the private member of the base class it will give error
    // if we try to access the public member of the base class it will work
    // if we try to access the internal member of the base class it will work
    // so in derived class we can access public, internal, protected and protected internal members of the base class
    // but not the private members
    //
    class Acess_Specifier2:Acess_Speciers
    {
      //static void Main()
      //  {

      //     Acess_Specifier2 t = new Acess_Specifier2();
      //      //t.Test1(); // Private Method - Not Accessible
      //      t.Test2(); // Public Method - Accessible
      //      t.Test3(); // Internal Method - Accessible
      //      t.Test4(); // Protected Method - Accessible (because of inheritance)
      //      t.Test5(); // Protected Internal Method - Accessible (because of inheritance)
      //  }
    }
}
