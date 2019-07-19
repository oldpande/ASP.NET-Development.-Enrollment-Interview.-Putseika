using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NETDevelopment.EnrollmentInterview.Putseika
{
    public class NewMath
    {
        public static int GetGCD(int a, int b)
        {
            if (a < 2 || b < 2)
            {
                throw new Exception("Please enter a number greater than one.");
            }

            if (IsPrimeNumber(a) || IsPrimeNumber(b))
                return 1;


            /// step 1: find all prime numbers which can use for division
            List<int> listA = SearchPrimeNumbers(a);
            List<int> listB = SearchPrimeNumbers(b);

            /// step 2: division of numbers by the initial number.
            listA = DividedNumbers(a, listA);
            listB = DividedNumbers(b, listB);

            ///step 3: find GCD
            int result = 1;

            var grouped1 =
                from n in listA
                group n by n
                into g
                select new { g.Key, Count = g.Count() };

            var grouped2 =
                from n in listB
                group n by n
                into g
                select new { g.Key, Count = g.Count() };

            var joined =
                from bElement in grouped2
                join aElement in grouped1 on bElement.Key equals aElement.Key
                select new { bElement.Key, Count = Math.Min(bElement.Count, aElement.Count) };

            var resultList = joined.SelectMany(aElement => Enumerable.Repeat(aElement.Key, aElement.Count));

            foreach (int element in resultList)
                result *= element;


            return result;
        }

        private static List<int> DividedNumbers(int a, List<int> primeNumbersList)
        {
            List<int> dividedNumbersList = new List<int>();

            while (a > 1)
            {
                foreach (int number in primeNumbersList)
                {
                    if (a % number == 0)
                    {
                        a /= number;
                        dividedNumbersList.Add(number);
                        break;
                    }

                }
            }
            return dividedNumbersList;
        }

        private static bool IsPrimeNumber(int n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        private static List<int> SearchPrimeNumbers(int n)
        {
            List<int> result = new List<int>();
            bool flag;

            for (int i = 2; i < n; i++)
            {
                flag = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    result.Add(i);
            }

            return result;
        }
    }
}
