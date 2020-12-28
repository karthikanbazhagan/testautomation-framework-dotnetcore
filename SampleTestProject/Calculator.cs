namespace SampleTestProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a , int b)
        {
            return a * b;
        }

        public const string PLUS = "added";
        public const string MINUS = "substracted";
        public const string MULTIPLY = "multiplied";
    }
}
