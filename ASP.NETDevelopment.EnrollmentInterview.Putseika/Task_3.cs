using System;

namespace ASP.NETDevelopment.EnrollmentInterview.Putseika
{
    class Task_3
    {
        public static void OrderStringsByLength(string[] arrOfString)
        {
            string swap = "";
            for (int i = 0; i < arrOfString.Length; i++)
            {
                for (int j = arrOfString.Length - 1; j > i; j--)
                    if (arrOfString[j - 1].Length > arrOfString[j].Length)
                    {
                        swap = arrOfString[j - 1];
                        arrOfString[j - 1] = arrOfString[j];
                        arrOfString[j] = swap;
                    }
            }
        }

    }
}
