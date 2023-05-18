    using System;

namespace ConsoleApp1
{
    public class main_method
    {
        static void Main()
        {
            Class1 g;

            g = new World1();

            g.Hello();

            g = new World2();

            g.Hello();
        }
    }
}
public abstract class Class1
{
    public abstract void Hello();
}
public class World1 : Class1
{
    public override void Hello()
    {
       Console.WriteLine("class world1");
    }
}
public class World2 : Class1
{
    public override void Hello()
    {
        Console.WriteLine("class World2");
    }
}