using System;

namespace ConsoleApp2
{

    interface Shape
    {
        double GetArea();
    }

    class Rectangle : Shape
    {
        double width;
        double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return width * height;
        }
    }

    class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 5);
            Shape circle = new Circle(2);

            Console.WriteLine(rectangle.GetArea()); // Output: 50
            Console.WriteLine(circle.GetArea()); // Output: approximately 12.57
        }
    }
} 