using System;

namespace VsCodeProj1
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = MyBuilder.Summa(4, 5);
            A x = new A("ffff");
            var t = x.Sum(z, 11);
            Console.WriteLine("Hello World! " + t.ToString());
        }
    }
}

