using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
    class UserInput
    {
        public UserInput()
        {
            Console.WriteLine("enter your name: ");
            String name = Console.ReadLine();
            if ((name.Length >= 3))
                Console.WriteLine("hello " + name + ", how are you...!");
            else Console.WriteLine("invalid name, should have atleast 3 charectors....!");
        }

    }
}
