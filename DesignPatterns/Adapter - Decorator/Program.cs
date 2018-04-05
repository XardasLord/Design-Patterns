using System;

namespace Adapter___Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a string builder which can work with concatenating like strings
            // We can just substitute the string for a string builder and we're good to go
            // There is no additional changes that are required here.

            // The great thing about this example is that with a single line change you can build an adapter which 
            // on one hand it's a decorator over a string builder because you need one and you cannot inherit from
            // on the other hand it's an adapter because it satisfies the interface and the interface requirements
            // are that you have implicit conversion from string to a string builder and you have operator plus equals (+=)

            //var s = "hello ";
            MyStringBuilder s = "hello ";
            s += "world";
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
