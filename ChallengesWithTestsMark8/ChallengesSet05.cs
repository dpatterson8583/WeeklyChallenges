using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int res = 0;
            for(int i = startNumber+1; i <= startNumber+100;i++) 
            {
                if (startNumber == 0)
                {
                    res = n;
                    break;
                }
                else if ( i % n == 0 )    
                {  
                    res= i;
                    break;
                }
  
   
            }
            return res;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business b in  businesses)
            {
                if (b.TotalRevenue==0.0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null) return false;

            if (numbers.Length == 0) return false;

            bool stillAsc = true;
            for(int i=0; i<numbers.Length-1;i++)
            {
                if (numbers[i]>numbers[i+1])
                {
                    stillAsc = false;
                }
            }

            return stillAsc;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int res = 0;

            if  (numbers == null) { return 0; }

            if (numbers.Length == 0) {  return 0; }

             for(int i=0; i<numbers.Length-1;i++ )
            {
                if (numbers[i] % 2==0)
                {
                    res += numbers[i + 1];
                }
             }
  
             return res;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";
            if (words.Length == 0) return "";

            string res = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                { 
               
                    res += word.Trim();
                    res += " ";
                    res = res.Trim();
                }
            }

            if (res.Length > 0)
            {
                return res.Trim() + ".";
            }
            else return "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {   
            List<double> res = new List<double>();
            double[] res1 = new double[0];
            int j=0;

            if (elements == null) { return res1;  }

            for(int i=0;i<elements.Count;i++)
            {
                j++;
                if (j == 4)
                {
                    res.Add(elements[i]);
                    j = 0;
                }
                
            }
            return res.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool res = false;
         
            for (int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        res = true;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
