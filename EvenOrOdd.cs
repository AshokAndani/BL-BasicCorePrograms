using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
     class EvenOrOdd
    {
        public EvenOrOdd()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("Entered number is Even");
            }
            else
            {
                Console.WriteLine("Entered Number is Odd");
            }
        }
    }
}
