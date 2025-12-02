namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 3;

            Console.WriteLine("Rectangle Details:");
            Console.WriteLine(rectangle.ShowDetails());
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}
