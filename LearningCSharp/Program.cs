using System;

namespace LearningCSharp
{
 
    
    class Program
    {
  
        public static void Main()
        {

            var Rect = new Rectangle();
            {
                var Success = false;
                do //Get the Width
                {



                    Console.Write("Please enter the Width: ");
                    if (double.TryParse(Console.ReadLine(), out var Width))
                    {
                        Rect.Width.Value = Width;
                        Console.WriteLine("What are the units for the Width? (I=Inches, F=Feet, Y=Yards): ");
                        
                        string UnitIn = Console.ReadLine();
                        switch (UnitIn.ToUpper())
                        {
                            case "I":
                                    Rect.Width.Unit = Unit.Inch;
                                break;
                            case "F":
                                    Rect.Width.Unit = Unit.Foot;
                                break;
                            case  "Y":
                                    Rect.Width.Unit = Unit.Yard;
                                break;
                        }
                        Success = true;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a valid Width!");
                        Console.WriteLine("Please try again.");
                    }

                } while (Success == false);
            }

            {
                var Success = false;
                do //Get the length
                {

                    Console.Write("Please enter the Length: ");
                    if (double.TryParse(Console.ReadLine(), out var Length))
                    {
                        Rect.Length.Value = Length;
                        Success = true;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a valid Length!");
                        Console.WriteLine("Please try again.");
                    }

                } while (Success == false);
            }

            Console.Clear();
            Console.WriteLine($"The Width is: {Rect.Width.Value}");
            Console.WriteLine($"The Length is: {Rect.Length.Value}");
            Console.WriteLine($"The area is: {Rect.Area.Value}");
            Console.WriteLine($"The Perimeter is: {Rect.Perimeter.Value}");
            Console.WriteLine($"The Diaganol is: {Rect.Diagonal.Value}");

            Console.ReadLine();
        }
    }
}
