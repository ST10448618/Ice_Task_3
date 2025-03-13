using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Rectangle: Shape
    {
        double length {  get; set; }
        double width { get; set; }

        public Rectangle(string name, double length, double width):base(name)
        {
            this.length = length;
            this.width = width;
        }

        public void Display()
        {
            Console.WriteLine($"Surface Area: ");
        }
    }
}
