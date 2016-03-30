using System;
using System.Text;

    class IsoscelesTriangle
    {
        static void Main()
        {
        Console.OutputEncoding = Encoding.Unicode;
        char c = '\u00A9';
        Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", c);
        }
    }
