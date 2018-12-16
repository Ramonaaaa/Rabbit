using System;

namespace OOP_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Rabbit r = new Rabbit("blue", "grey", now.AddYears(-2), true);
            Console.WriteLine("Details about my rabbit: " + r);
            Console.WriteLine("Age of the rabbit: " + r.Age + " days");
        }
    }

}
