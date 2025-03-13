using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    abstract class Shape
    {
        string name {  get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Area of {name}= ");
        }
    }
}
