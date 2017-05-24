using System;
using TestClassLibrary;

namespace TestConsoleAppliaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellocome to Test Console Application:");
            Console.WriteLine("Input user name:");

            var userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            Console.WriteLine("Reversed user data:");
            Console.WriteLine(SomeWorkRep.ReversedUserData(userName));

            Console.ReadKey();
        }
    }
}
