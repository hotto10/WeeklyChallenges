using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           if (vals == null)
                return false;
            
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           if (numbers == null || !numbers.Any())
                return false;
            
            var sum = numbers.Sum();

            return sum % 2 != 0;

           
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            return password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return (char)val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if ( divisor == 0)
                return 0;

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            
            var odd = Enumerable.Range(0, 100).Where(i => i %2 != 0);
            return odd.ToArray();

           
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
