using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rectangle1 = new Rectangle();
            Rectangle.GetInfo();
            Console.WriteLine(GetArea());

            Square Square1 = new Square();
            Square.GetInfo();
            Console.WriteLine(GetArea());

            Triangle Triangle1 = new Triangle();
            Triangle.GetInfo();
            Console.WriteLine(GetArea());
        }
    }
}
