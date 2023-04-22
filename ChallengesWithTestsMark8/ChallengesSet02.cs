using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.Json.Serialization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(char.IsLetter(c))
            {
                return true;
            }
            else
            {  
                return false; 
            }     
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
           return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count()==0)
            {
                return 0.0;
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int atotal = numbers.Sum();
            return atotal;
        }

        public int SumEvens(int[] numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    total += n;
                }
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers==null)
            { 
                return false; 
            }

            int atotal = numbers.Sum();
            if (atotal % 2 != 0) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
           for(int i=1;i<number;i++) 
            {
                if (i % 2 !=0) 
                { 
                   count++; 
                }
            }
            return count;
        }
    }
}
