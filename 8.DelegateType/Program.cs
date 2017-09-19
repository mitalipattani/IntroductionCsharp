using System;

namespace _8.DelegateType
{
    //Decalre a delegate outside class
    delegate double MathAction(double num);

    class Program
    {
        //create a method that matches signature of delegate
        static double Multiplication(double input)
        {
            return input * 2;
        }

        static void Main(string[] args)
        {
            //Create an instance for delegate with named method
            MathAction m1 = Multiplication;
            //invoke the delegate instance
            double ans = m1(4.5);
            Console.WriteLine(ans);
            //Createing a second instance and performs square
            MathAction m2 = delegate (double input)
            {
                return input * input;
            };
            double square = m2(5.375);
            Console.WriteLine(square);

            //create one more instance with lambda expression
            MathAction m3 = s => s * s * s;
            double cube = m3(3.222);
            Console.WriteLine(cube);
            Console.Read();
        }
    }
}
