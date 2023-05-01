using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
             
            return Math.Min(Math.Min(Math.Min(str1.Length, str2.Length), str3.Length),str4.Length);
         
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2),number3),number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            else if ((sideLength1 + sideLength2 > sideLength3) &&
                (sideLength1 + sideLength3 > sideLength2) &&
                (sideLength2 + sideLength3 > sideLength1))
            {
                return true;
            }
            else return false;
        }

        public bool IsStringANumber(string input)
        {
             return double.TryParse(input,out double x);;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int Count = 0;
            int arrSize = objs.Length;

            foreach (object obj in objs)
            {
          
                if (obj == null || obj is null)
                {
                    Count++;
                }
            }

            return Count > (arrSize / 2) ? true : false;
            
        }

        public double AverageEvens(int[] numbers)
        {
            //return numbers.Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
