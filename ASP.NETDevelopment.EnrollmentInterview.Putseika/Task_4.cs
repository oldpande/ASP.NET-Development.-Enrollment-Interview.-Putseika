using System;
using System.Text;

namespace ASP.NETDevelopment.EnrollmentInterview.Putseika
{
    class Task_4
    {
        public static void RemoveDuplicateWords(ref string inputtedString)
        {
            string[] words = inputtedString.Split(' ', '?', '!', '.', ',', '-', ':', ';');
            string[] newWords = new string[words.Length];
            for (
                int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (newWords[j] == words[i])
                    {
                        newWords[i] = "";
                        break;
                    }
                    else
                        newWords[i] = words[i];
                }
            }

            string fixedString = "";
            for (int i = 0; i < newWords.Length; i++)
                fixedString += newWords[i] + " ";
            inputtedString = fixedString;
        }
    }
}
