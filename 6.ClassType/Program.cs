using System;

namespace _6.ClassType
{
    class ProgramClass
    {
   
        static void Main(string[] args)
        {
            Personp p1 = new Personp("Craig" , 10);
            Personp p2 = new Personp("salley", 29);
            Console.WriteLine("Child #1");
            p1.PrintPerson();
            Console.WriteLine("Child #2");
            p2.PrintPerson();
            Console.Read();
        }
    }
}
