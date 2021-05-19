using System;

namespace LearningCSharp
{
 
    
    class Program
    {
  
        public static void Main()
        {

            var Rect = new Rectangle();
            Boolean Success;

            do
            {
                
                try
                {
                    Console.Write("Please enter the Width: ");
                    Rect.Width(Console.ReadLine());
                    Success = true;
                }
                catch (Exception)
                {
                    Success = false;
                    Console.Clear();
                    Console.WriteLine("You must enter a valid Width!");
                    Console.WriteLine("Please try again.");
                } 
            } while (Success==false);

            do
            {
                Success = false;
                try
                {
                    Console.Write("Please enter the Length: ");
                    Rect.Length(Console.ReadLine());
                    Success = true;
                }
                catch (Exception)
                {

                    Success = false;
                    Console.Clear();
                    Console.WriteLine("You must enter a valid Length!");
                    Console.WriteLine("Please try again.");
                }
            } while (Success == false);

            Console.Clear();
            Console.WriteLine($"The Width is: {Rect.Width()}");
            Console.WriteLine($"The Length is: {Rect.Length()}");
            Console.WriteLine($"The area is: {Rect.Area}");
            Console.WriteLine($"The Perimeter is: {Rect.Perimeter}");
            Console.WriteLine($"The Diaganol is: {Rect.Diagonal}");
        }
    }
}
