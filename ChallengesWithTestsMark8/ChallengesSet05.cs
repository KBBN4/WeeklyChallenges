using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            startNumber++;
            while(startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;

            //return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();
            //for (var i =0; i < businesses.Length; i++)
            //{
            //    if (businesses[i].TotalRevenue == 0)
            //    {
            //        businesses[i].Name = "closed";
            //    }
            //}

            foreach (var business in businesses)
            {
                if( business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
           if ( numbers == null || numbers.Length == 0)
            {
                return false;
            }


            var orderNumber = numbers.OrderBy(x => x).ToArray();
                return (orderNumber.SequenceEqual(numbers));
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if ( numbers == null)
            {
                return 0;
            }
            for ( int i =0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {    List<double> list = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                
                return list.ToArray();
            }
            
            // throw new NotImplementedException();
            for (int i = 3; i < elements.Count;  i += 4)
            {
                list.Add(elements[i]);

            }

            return list.ToArray();
        }      

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i =0; i < nums.Length; i++)
            {
                for ( int x = i =1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                } 
            }
                       return false;
        }           
    }
}
