using System;
using System.Collections.Generic;
using System.Text;

    class Personp
    {

        private int age;
        private string name;

        //Constructor
        public Personp(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //Method
        public void PrintPerson()
        {
            Console.WriteLine("{0} ,{1} years old", name, age);
        }

}

