using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool res = false;

            if(words == null) { return false; }

            foreach(var item in words)
            {
                if (item == null)  { res = false; }
                else if (ignoreCase)
                {
                    {
                        res = item.ToLower() == word.ToLower();
                        if (res) { break; }
                    }
                }
                else
                {
                    res = item == word;
                    if (res) { break; }
                }
            }
            return res;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
         
            if(num >=0)
            {
                if (num == 1)           { isPrime = false; }
                else if (num == 2 || num == 3)       { isPrime = true; }
                else if ((num+1) % 6 == 0 || (num - 1) % 6 == 0)        { isPrime = true;}
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex=false;

            for(int i=0; i<str.Length; i++)
            {
                uindex = true;

                for(int j=0; j<str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if (uindex) { index = i; }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int final_count=0;
            
            for(int i=0;i<numbers.Length;i++)
            {
                int curr_count = 1;

                for (int j=i+1;j<numbers.Length;j++)
                {
                   
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    curr_count++;

                    if(curr_count > final_count)
                    {
                        final_count = curr_count;
                    }
                }
            }

            return final_count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            // THIS WORKS BUT THE CODE BELOW WORKS BETTER.  LESS LOOPING AND INDIVIDUAL CHECKING.
            /*          int count = 0;
                      int newsize = 1;

                      double[] result = new double[0];
                      if(elements ==null) { return result; }

                      foreach(double el in elements) 
                      {
                          count++;
                          if(count==n) 
                          {
                              Array.Resize(ref result, newsize);
                              result[result.Length - 1] = el;
                              newsize++;
                              count = 0;
                          }
                      }
                      return result;*/


            if (elements == null || n <= 0) { return Array.Empty<double>(); }
   
            int newsize = 0;
            newsize = (elements.Count / n);
            double[] result = new double[newsize];


            for (int i=1;i<=newsize;i++)
            {
                result[i-1] = elements[i*n-1];
            }
            return result;

        }
    }
}
