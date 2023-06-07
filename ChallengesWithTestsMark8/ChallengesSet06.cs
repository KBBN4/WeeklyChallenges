using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();

            if(words == null || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                foreach(var w in words)
                {
                    if (w.ToLower() == word.ToLower())
                    {
                        return true;
                    }             
                }
            }

            if (ignoreCase == false)
            {
                if (words.Contains(word))
                {
                    return true;

                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {


            if ( num <= 1)
            {
                return false;
            }

            if( num % 2 != 0 & num % 3 != 0)
            {
                return true;
            }
            if( num == 2 || num == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //throw new NotImplementedException();

            int index = -1;

            if(str == "")
            {
                return index;
            }
            if(str.Length == 1)
            {
                return 0;
            }

            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x] && i != x)
                    {
                        uniqueIndex = false;
                    }
                }
                if (uniqueIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //throw new NotImplementedException();


            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currenCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currenCount++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (currenCount > count)
                {
                    count = currenCount;
                }
            }
            return count;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();

            List<double> newList = new List<double>();

            if ( elements == null || n == 0 || n < 0 || n > elements.Count)
            {
                return newList.ToArray();

            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    newList.Add(elements[i]);
                }

            }
            return newList.ToArray();

        }
    }
}
