using System;

namespace IntegerSwapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A Value");
            Console.WriteLine("A: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B Value");
            Console.WriteLine("B: ");
            int b =Convert.ToInt32(Console.ReadLine());
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("New value of A: "+a);
            Console.WriteLine("New value of B: "+b);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
