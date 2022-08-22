using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate worldDelegate = WriteHello;
            worldDelegate += GoodBye;

            worldDelegate();
        }


        delegate void Delegate();

        static void WriteHello()
        {
            Console.WriteLine("Hello World!");
        
        }

        static void GoodBye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
