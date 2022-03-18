using System;

namespace taskno2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eded 3-e bolunen cutdur, 3- e bolunen tekdir
            int a;
            a = 24;
            if (a % 3 == 0 && a % 2 == 0)
            { Console.WriteLine(" 3-e bolunur cutdur"); }
            else if (a % 3 == 0 && a % 2 == 1)
            { Console.WriteLine("3-e bolunen tek ededdir"); }
            else { Console.WriteLine("3-e bolunmur"); }
        }
    }
}
