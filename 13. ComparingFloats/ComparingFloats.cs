using System;
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter first floating point number: ");
            double one = double.Parse(Console.ReadLine());

            Console.Write("Enter second floating point number: ");
            double two = double.Parse(Console.ReadLine());

            bool equal = Math.Abs(one - two) < 0.000001;

            Console.WriteLine("{0} == {1} ---> {2}", one, two, equal);
        }
    }

