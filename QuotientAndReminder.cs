using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
     class QuotientAndReminder
    {
        public QuotientAndReminder()
        {
            Console.Write("Enter Dividend:");
            float dividend = float.Parse(Console.ReadLine());
            Console.Write("Enter Divisor:");
            float divisor=float.Parse(Console.ReadLine());
            float quo = dividend / divisor;
            float reminder=dividend % divisor;
            Console.WriteLine("qoutient is : "+quo);
            Console.WriteLine("reminder is: "+reminder);
        }
    }
}
