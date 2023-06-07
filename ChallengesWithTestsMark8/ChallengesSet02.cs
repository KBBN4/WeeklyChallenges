using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'a' && c <= 'z' || (c >= 'A' && c <= 'Z'));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;

        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
            double min = (double)numbers.Min();
            double max = (double)numbers.Max();
            double Sum = min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);


        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            // throw new NotImplementedException();


            while (numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];

                    }
                    return sum;
                }
               
            }
            return 0;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if ( numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }
       

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;

            for ( int i =1; i <number; i +=2)
            {
                count++;

            }
            return count;
        }
    }
}
