namespace Ice_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", 5, 10);
            rectangle.Display();

            Circle circle = new Circle("Circle", 7);
            circle.Display();
        }
    }
}
