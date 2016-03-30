using System;
    class QuotesInStrings
    {
        static void Main()
        {
            string a = "The \"use\" of qoutations causes difficulties.";
            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
