using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set {  length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea() => length * width;

        public double GetPerimeter() => 2 * (length + width);

        public string ShowDetails() => $"Length: {length}, Width: {width}";
    }
}
