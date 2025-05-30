using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ConsoleApp1
{
    public class Person
    {
        //fields
        private string name;
        private int age;

        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}. I am {Age} year old.");

        }
    }


}
