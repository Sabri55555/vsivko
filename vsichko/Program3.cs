using System;

namespace ConsoleApp3
{
   abstract class AbstractClass
   
        public int AddTwonumbers(int Num1, int Num2);
        {
            return Num1 + Num2;
        }
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
}
class Derived : AbstractClass
{
    public override int MultiplyTwoNumbers(int Num1, int Num2);
    {
        return Num1 * Num2;
    }
}
class Example
{
    public static void Main()
    {
        Derived d = new Derived();

        Console.WriteLine("Addition : {0}\nMultiplication :{1}", d.AddTwoNumbers(6, 3), d.MultiplyTwoNumbers(3, 6));
    }
}



