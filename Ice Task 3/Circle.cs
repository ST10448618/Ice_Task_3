using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Circle: Shape,CalculateArea
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        // Implementing CalculateArea method
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }
}
