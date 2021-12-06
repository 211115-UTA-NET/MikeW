using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        int RecLength = 10;
        int Area = RecLength * RecLength;
        public Rectangle(int RecLength, string Name, int NumSides, int Area) : base(name, NumSides)
        {
            this.RecLength = RecLength;
        }
    }
}
