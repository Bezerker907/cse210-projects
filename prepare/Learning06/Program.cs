using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Orange", 3);
        shapes.Add(square);

        Circle circle = new Circle("Yellow", 2);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("Red", 3, 4);
        shapes.Add(rectangle);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape's area is {area}.");
        }
    }
}