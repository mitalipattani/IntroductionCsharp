using System;

namespace _5.NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? someInteger = null;
            Console.WriteLine("This is integer with Null Value {0}", someInteger);
            someInteger = 5;
            Console.WriteLine("value is changed to {0}", someInteger);
            Console.Read();
        }
    }
}
