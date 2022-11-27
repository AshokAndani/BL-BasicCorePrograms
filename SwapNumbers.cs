using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
    class SwapNumbers
    {
        public SwapNumbers()
        {
            Console.WriteLine("Enter numbers for swapping");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int temp = num1;
            num1= num2;
            num2 = temp;
            // swapped...!
        }
    }
}
