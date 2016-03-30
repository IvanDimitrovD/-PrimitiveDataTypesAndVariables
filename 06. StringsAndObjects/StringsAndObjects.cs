using System;
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object both = hello + " " + world;
            string backToStr = (string)both;
            Console.WriteLine(backToStr);
        }
    }
