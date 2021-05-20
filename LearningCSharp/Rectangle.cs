using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{

    public enum Unit
    {
        Inch = 1,
        Foot = 12,
        Yard = 36,
    }

    public class LengthUnit
    {
        public Unit Unit { get; set; }
        public double Value { get; set; }

        public double LengthInInches
        {
            get {
                return (double)Unit * Value;
            }
        }

        public static AreaUnit operator*(LengthUnit Left, LengthUnit Right)
        {
            return new AreaUnit()
            {
                Length = Left.LengthInInches * Right.LengthInInches,
                Unit = Unit.Inch
            };
        }

        public static LengthUnit operator*(LengthUnit Left, int Right)
        {
            return new LengthUnit()
            {
                Value = Left.LengthInInches * Right,
                Unit = Unit.Inch
            };
        }

        public static LengthUnit operator+(LengthUnit Left, LengthUnit Right)
        {
            return new LengthUnit()
            {
                Value = Left.LengthInInches + Right.LengthInInches,
                Unit = Unit.Inch
            };
        }

    }

    public class AreaUnit
    {
        public Unit Unit { get; set; }
        public double Length { get; set; }
    }



    public class Rectangle
    {
        public LengthUnit Length { get; } = new();
        public LengthUnit Width { get; } = new();

        public AreaUnit Area
        {
            get { return Length * Width; }
        }
        public LengthUnit Perimeter
        {
            get { return (Length * 2) + (Width * 2); }
        }

        public AreaUnit Diagonal
        {
            get {
                return new AreaUnit()
                {
                    Length = Math.Sqrt(Math.Pow(Length.LengthInInches, 2) + Math.Pow(Width.LengthInInches, 2)),
                    Unit = Unit.Inch
                };
            }
        }
    }

    class Rectangle_old
    {
        private double _length = 0;
        private double _width = 0;
        
        public void Length(string value)
        {

            try

            {
                _length = Convert.ToDouble( value);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void Length(double value)
        {
            _length = value;
        }

        public double Length()
        {
            return _length;
        }

        public void Width(string value)
        {
            try
            {
                _width = Convert.ToDouble(value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Width(double value)
        {
            _width = value;
        }
        public double Width()
        {
            return _width;
        }

        public double Area
        {
            get { return _length * _width; }
        }
        public double Perimeter
        {
            get { return (_length * 2) + (_width * 2); }
        }
        
        public double Diagonal
        {
            get { return  Math.Sqrt( Math.Pow(_length,2) + Math.Pow(_width, 2)) ;  }
        }


    }
}

