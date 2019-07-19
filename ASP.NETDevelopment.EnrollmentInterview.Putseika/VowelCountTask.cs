using System;

namespace ASP.NETDevelopment.EnrollmentInterview.Putseika
{
    class VowelCountTask
    {
        private static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public static int CountOfVowels(string inputString)
        {
            int countOfVowels = 0;
            foreach (char symbol in inputString)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (symbol == vowels[i])
                        countOfVowels++;
                }
            }
            return countOfVowels;
        }
    }
}
