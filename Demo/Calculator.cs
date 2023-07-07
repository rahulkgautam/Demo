using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Calculator
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter first Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            int c = Convert.ToInt32(Console.ReadLine());
            int mul = a * b * c;
            Console.WriteLine("Multipication of Three numbers " + mul);
        }
    }
}
