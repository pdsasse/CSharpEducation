using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Rectangle
    {
        private double _length = 0;
        private double _width = 0;
        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        public double Area
        {
            get { return _length * _width; }
        }
        public double perimeter
        {
            get { return (_length * 2) + (_width * 2); }
        }
        public void PrintArea()
        {
            Console.WriteLine($"Area is: {_length * _width}");
        }
        public void PrintPerimeter()
        {
            Console.WriteLine($"Perimeter is: {(_width * 2) + (_length * 2)}");
        }
        public bool GetLengthAndWidth()
        {
            string buffer = "";
            bool success = false;
            do
            {
                try
                {
                    Console.Write("Enter Length: ");
                    buffer = Console.ReadLine();
                    this.Length = Convert.ToDouble(buffer);
                    success = true;
                }
                catch
                {
                    Console.WriteLine("You must enter a valid nueric value.");
                }

            }
            while (!success);
            success = false;
            buffer = "";
            do
            {
                try
                {
                    Console.Write("Enter width: ");
                    buffer = Console.ReadLine();
                    this.Width = Convert.ToDouble(buffer);
                    success = true;
                }
                catch
                {
                    Console.WriteLine("You must enter a valid nueric value.");
                }

            }
            while (!success);
            return true;
        }
    }
}

