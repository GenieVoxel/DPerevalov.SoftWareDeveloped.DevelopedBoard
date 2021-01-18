using System;
using System.Collections.Generic;
using System.Text;

namespace DPerevalov.SoftWareDeveloped.MajorProject
{
    public static class Settings
    {
        /// <summary>
        /// Определяем стаж
        /// </summary>
        public static int CalculateAge(DateTime BirthDate, DateTime dateTime)
        {
            int YearsPassed = dateTime.Year - BirthDate.Year;

            if (YearsPassed <= 0)
            {
                if (dateTime.Month < BirthDate.Month || (dateTime.Month == BirthDate.Month && dateTime.Day < BirthDate.Day))
                {
                    YearsPassed--;
                }
            }

            Console.WriteLine(YearsPassed);

            return YearsPassed;
        }
    }
}
