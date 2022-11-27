using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
    class LargestOfThree
    {
        public LargestOfThree()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!");
                }
                else
                {
                    Console.Write("Number three is the largest!");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!");
            else
                Console.Write("Number three is the largest!");
        }
    }
}
