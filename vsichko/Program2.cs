using System;

namespace ConsoleApp2
{
                   
        abstract class AreaClass
        {
            abstract public int Area();
        }
        class Square : AreaClass
        {
            int side = 0;
            public Square(int n)
            {
                side = n;
            }
            public override int Area()
            {
                return side * side;
            }
        }
        class Example
        {
            public static void Main()
            {
                Square s = new Square(6);
                Console.WriteLine("Area = " + s.Area());
            }
        }
}

    

