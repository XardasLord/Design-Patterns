using System;

namespace Null_Object
{
    class Program
    {
        static void Main(string[] args)
        {


            // Except passing null as a parameter for the BankAccount class and putting it in a try/catch block you cant just replace the standard
            // ConsoleLog to the NullLog which is doing nothing at all -> empty methods, for example.
            //
            //var log = new ConsoleLog();
            var log = new NullLog();
            var ba = new BankAccount(log); // Everything works fine here, cause NullLog class has empty methods which it implements from the ILog interface
            ba.Deposit(100);


            Console.ReadLine();
        }
    }
}
