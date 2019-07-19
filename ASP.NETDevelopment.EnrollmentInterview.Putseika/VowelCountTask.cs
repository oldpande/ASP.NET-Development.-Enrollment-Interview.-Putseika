using System;

namespace ASP.NETDevelopment.EnrollmentInterview.Putseika
{
    class VowelCountTask
    {
        private static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public static int CountOfVowels(string inputtedString)
        {
            int countOfVowels = 0;
            foreach (char symbol in inputtedString)
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
