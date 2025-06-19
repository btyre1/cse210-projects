using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Blue", 5);
        Rectangle r1 = new Rectangle("Black", 5, 9);
        Circle c1 = new Circle("Red", 3.6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shp in shapes)
        {
            Console.WriteLine($"The shape is {shp.GetColor()} and has an area of {shp.GetArea()}.");
        }
    }
}