using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if(numbers == null)
                return 0;
            int sum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    sum += item;

                else
                    sum -= item;
            }
            return sum;
            

                
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortestString = 100000;

            if (str1 == null || str2 == null || str3 == null || str4 == null)
                return 0;
            if (str1.Length < shortestString)
                shortestString = str1.Length;

            if (str2.Length < shortestString)
                shortestString = str2.Length;
            
            if(str3.Length < shortestString)
                shortestString = str3.Length;
            
            if (str4.Length < shortestString)
                shortestString = str4.Length;

            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallestNumber = 1000;

            if (number1 < smallestNumber)
                smallestNumber = number1;
            if (number2 < smallestNumber)
                smallestNumber = number2;
            if (number3 < smallestNumber)
                smallestNumber = number3;
            if(number4 < smallestNumber)
                smallestNumber= number4;
            return smallestNumber;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if(double.TryParse(input, out double value))
            {
                return true;
            }
            return false ;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCt = objs.Length;
            int nullCt = 0;
            foreach (var obj in objs)
            {
                if (obj == null) nullCt++;
            }
            if(nullCt > itemCt / 2) 
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int evenSum = 0;
            int evenCt = 0;
            
            foreach (int i in numbers)
            {
                if(i % 2 == 0)
                {
                    evenSum += i;
                    evenCt++;
                }
                    
            }
             if (evenCt == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCt;
            
        }

        public int Factorial(int number)
        {
            if (number < 0 ) throw new ArgumentOutOfRangeException();
            if (number == 0) return 1;
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }
        }
    }
}
