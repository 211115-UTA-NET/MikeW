using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        private int SqLength = 5;

        public Square(int SqLength, String name, int NumSides)
        {
            this.SqLength = SqLength;
        }
    }
}
