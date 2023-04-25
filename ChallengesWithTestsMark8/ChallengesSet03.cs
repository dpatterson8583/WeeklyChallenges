using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var res = false;
            foreach (var v in vals)
            {
                if (!v)
                {
                    res = true;
                    break;
                }
               
            }
            return res;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            if(numbers == null)
            { return false; }

            foreach(var v in numbers)
            { 
               if(v % 2 != 0)
               {
                   sum += v;
               }
                    
            }
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var pw =  password;
            bool hasUpper = false; 
            bool hasLower = false; 
            bool hasDigit = false;
            for (int i = 0; i < pw.Length; i++)
            {
                char c = pw[i];
                if (!hasUpper)
                { hasUpper = char.IsUpper(c); }

                if (!hasLower)
                { hasLower = char.IsLower(c); }

                if (!hasDigit)
                { hasDigit = char.IsDigit(c); }
            }
            return hasUpper && hasLower && hasDigit;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1]; 
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            { return 0; }
            else { 
            return dividend / divisor;
        }
        }
        
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1]-nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] arr = new int[50];

            for(int i=0;i<100;i++)
            {
                if(i % 2 != 0)
                {
                    arr[i/2] = i;
                }
            }
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i=0; i<words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
