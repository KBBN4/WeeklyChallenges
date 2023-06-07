using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            // throw new NotImplementedException();
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }

            }
            return false;


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if ( numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            //
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }

            }
            if (sum % 2 != 0)
            {
                return true;

            }

            return false;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            //throw new NotImplementedException();
            foreach (char p in password)
            {
                if (char.IsUpper(p))
                {
                    upper = true;
                }
                if (char.IsLower(p))
                {
                    lower = true;

                }

                if (char.IsNumber(p))
                {
                    number = true;
                }
            }
            if (upper && lower && number)
            {
                return true;
            }

            else
            {
                return false;
            }
            //if (upper && lower && number) ? true : false;


        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {


            return val[val.Length - 1];




            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;

            }
            else
            {
                return dividend / divisor;
            }
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];

            // throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 99; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }

            }
            return list.ToArray();
        }



        // throw new NotImplementedException();


        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //throw new NotImplementedException();
        }
    }
}


