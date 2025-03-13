using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    abstract class Shape
    {
        public string Name { get; set; }

        // Constructor
        public Shape(string name)
        {
            Name = name;
        }

        // Virtual Display Method
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
