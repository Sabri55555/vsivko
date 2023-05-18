using System;

namespace ConsoleApp3

interface ITransport
{
    void StartEngine();
}

class Car : ITransport
{
    public void StartEngine()
    {
        Console.WriteLine("Starting car engine...");
    }
}

class Boat : ITransport
{
    public void StartEngine()
    {
        Console.WriteLine("Starting Boat engine...");
    }
}

class Program
{
    static void Main(String[] args)
    {
        ITransport car = new Car();
        ITransport boat = new Boat();

        car.StartEngine(); // Output: "Starting car Engine..."
        boat.StartEngine(); // Output: "Starting boat engine..."
    }
}