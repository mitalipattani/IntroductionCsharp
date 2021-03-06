﻿using System;

namespace _7.InterfaceType
{
    interface myInterface //only signature
    {
        void SampleMethod();
    }

    class Program : myInterface
    {
        static void Main(string[] args)
        {
            //1.Declare an instance for interface
            myInterface i = new Program();
            //3.call the method from interface instance
            i.SampleMethod();
            Console.Read();
        }
        //2.implement the method
       public void SampleMethod()
        {
            Console.WriteLine("Interface Implementation");
        }
    }
}
