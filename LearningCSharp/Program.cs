using System;

namespace LearningCSharp
{
 
    
    class Program
    {
        static void Main()
        {

            var r = new Rectangle();
            if(r.GetLengthAndWidth())
            {
                r.PrintArea();
                r.PrintPerimeter();
            }
        }
    }
}
