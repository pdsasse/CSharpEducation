using System;

namespace LearningCSharp
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "What is your name";
            Console.Write("Type your first name: ");
            string firstname  = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {firstname}!");
            Console.ReadLine();
            
        }
    }

}