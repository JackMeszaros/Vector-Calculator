using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float ez = 3;
            Vector test1 = new Vector(4, 1, 3);
            Vector test2 = new Vector(-3, 2, -5);
            
            Console.WriteLine("test1 magnitude: " + test1.GetMagnitude());
            Console.WriteLine("test2 magnitude: " + test2.GetMagnitude());
            Console.WriteLine("test1 direction: " + test1.GetDirection());
            Console.WriteLine("test2 direction: " + test2.GetDirection());
            Console.WriteLine("Addition: " + Vector.Add(test1, test2));
            Console.WriteLine("Subtraction: " + Vector.Subtract(test1, test2));
            Console.WriteLine("Negation 1: " + Vector.Negate1(test1));
            Console.WriteLine("Negation 2: " + Vector.Negate(test2));
            Console.WriteLine("Scale (Vector 1) by 3: " + Vector.Scale(test1, ez));
            Console.WriteLine("Scale (Vector 2) by 3: " + Vector.Scale(test2, ez));
            Console.WriteLine("Normalize: " + Vector.Normalize(test1));
            Console.WriteLine("Normalize 2: " + Vector.Normalize(test2));
            Console.WriteLine("Dot product: " + Vector.DotProduct(test1, test2));
            Console.WriteLine("Cross product: " + Vector.CrossProduct(test1, test2));
            Console.WriteLine("Angle between: " + Vector.AngleBetween(test1, test2));
            Console.WriteLine("project onto: " + Vector.ProjectOnto(test1, test2));
        }
    }
}
