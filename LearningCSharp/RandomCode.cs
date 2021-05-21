using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LearningCSharp
{
    class RandomCode
    {
        public int StringLength { get; set; } = 8;

        public ArrayList ValueList { get; set; } = new ArrayList() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string Value 
        {
            get 
            {
                string buffer = "";
                if (StringLength == 0) { return buffer; }

                if (ValueList.Count>0)
                {
                    int min = 0;
                    int max = ValueList.Count;
                    Random random = new Random();
                    for (int i = 0; i < StringLength; i++)
                    {
                        int number = random.Next(min, max);
                        buffer += ValueList[number];
                    }


                    return buffer;
                }
                else 
                {

                    return buffer;
                }
            } 
        }
    }
}
