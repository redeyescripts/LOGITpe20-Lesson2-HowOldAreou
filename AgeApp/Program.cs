using System;

namespace HowOldAreou
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, What is your Name?");
            String Name;
            Name = Console.ReadLine();

            Console.WriteLine("Hello, " + Name);







            Console.WriteLine("What Year are you born in?");

           
           
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("You are "  + Age + " old.");


            Console.WriteLine("hello!," + Name  +Year);


        }
    }
}
