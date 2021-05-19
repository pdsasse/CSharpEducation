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

