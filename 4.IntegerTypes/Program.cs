using System;

namespace _4.IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = 20; //small numbers
            uint year = 2017;
            uint day = 730480;
            ulong hours = 17531520; //a very big number
            Console.WriteLine("{0} centuries {1} year or {2}" +
                "days or {3} hours", centuries, year, day, hours);
            //string type
            string fname = "Mitali";
            string lname = "Pattani";
            string fullName = fname + lname;
            Console.WriteLine("fanme = {0}, lname ={1} and fullname =" +
                "{2} ", fname, lname, fullName);
            //for equality (== and !=)
            string a = "hello";
            string b = "h";
            b += "ello"; //b = hello
            Console.WriteLine(a == b); //true
            Console.WriteLine((object)a == (object)b); //false , unboxing
            //content of strings literals are same but
            //a & b donot refer to same string instance
            //displaying a path
            //creating a verbatiam string
            string path = @"c:\Docs\Source\a.txt";
            Console.WriteLine("path is ={0}", path);
            //Object type
            object o1;
            o1 = 1.0f; //boxing
            //When you assign a value type to object its said boxing
            //When a variable of object is converted to value
            //its said as unboxing
            Console.WriteLine(o1);
            Console.WriteLine(o1.GetType());
            Console.Read();
        }
    }
}
