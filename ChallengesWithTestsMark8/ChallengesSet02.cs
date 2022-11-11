﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c); 
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length %2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            
            return number %2 == 0;
            
        }

        public bool IsNumberOdd(int num)
        {
            return num %2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;

            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            


        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;
            else
                return numbers.Sum();
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;
            
            var sum = numbers.Where(x => x % 2 == 0).Sum(); 
                return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null || !numbers.Any())
                return false;
            
            return numbers.Sum() % 2 != 0;
           
        }
        

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddsCounter = 0;
            for(int i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    oddsCounter++;
                }
                
            }
            return oddsCounter;
        }
    }
}
