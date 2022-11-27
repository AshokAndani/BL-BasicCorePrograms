using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProblems
{
    class IsVowel
    {
        public IsVowel()
        {
            char[] vowels = {'A','E','I','O','U' };
            Console.WriteLine("Enter an Alphabet:");
            char ch = Console.ReadLine()[0];
           bool flag=false;
            foreach(var vowel in vowels)
            {
                if(vowel == ch)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("Entered charactor is Vowel");
            }
            else
            {
                Console.WriteLine("Entered charactor is not Vowel");
            }
        }
    }
}
