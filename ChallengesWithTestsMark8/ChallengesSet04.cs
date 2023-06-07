using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
                
            }return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           var collection = new List<int> {  number1, number2, number3, number4 };

            return collection.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            // throw new NotImplementedException();
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;

        }

        public bool IsStringANumber(string input)
        {
            // throw new NotImplementedException();
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            int isNull = 0;

            foreach (var item in objs)
            {
                if ( item == null)
                {
                    isNull++;
                }
                else
                {
                    isNull--;
                }
                
           }
            return isNull > 0;
      

        }

        public double AverageEvens(int[] numbers)
        {
            if ( numbers == null || numbers.Length == 0)
            
                return 0;
            

            double sum = 0;
            double num = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    num++;
                }
            }

            if (num == 0) return 0;
            return sum / num;

            
        }

        public int Factorial(int number)
        {
            
            
             if (number < 0)
            {
                throw new ArgumentOutOfRangeException();

            }

             if ( number == 0)
            {
                return 1;
            }

            int ans = 1;
                for ( int i = 1; i <= number; i++)
            {
                ans *= i;
            }
            return ans;

        }
    }
}
