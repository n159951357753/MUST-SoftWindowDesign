using System;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 850000);
        Console.WriteLine("車名: " + myCar.GetName());
        Console.WriteLine("價格: " + myCar.GetPrice());
    }
}
