using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        private int TriLength = 8;

        public Triangle(int TriLength, string Name, int NumSides)
        {
            this.TriLength = TriLength;
        }
            // HINT: Use Herons Formula to calculate and set the area.
        //s= (a+b+c)/2
    }
}
